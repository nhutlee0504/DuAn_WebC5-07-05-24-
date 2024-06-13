using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DA_WebC5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Net.Mail;
using System.Net;
namespace DA_WebC5.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private string url = "http://localhost:57700/api/Account/";
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(u => u.Email == email);
            if (account != null)
            {
                // Generate a random code
                var resetCode = Guid.NewGuid().ToString("N").Substring(0, 6); // Generate a 6-character random code

                // Save reset code to the database
                account.ResetPasswordCode = resetCode;
                _context.Update(account);
                await _context.SaveChangesAsync();

                // Send email with reset code
                SendResetPasswordEmail(email, resetCode);

                return Content("Một email chứa mã xác nhận đã được gửi đến địa chỉ email của bạn. Vui lòng kiểm tra hộp thư để đặt lại mật khẩu.");
            }
            else
            {
                return Content("Email không tồn tại trong hệ thống. Vui lòng thử lại.");
            }
        }

        private void SendResetPasswordEmail(string email, string resetCode)
        {
            var fromAddress = new MailAddress("your-email@example.com", "Your Name");
            var toAddress = new MailAddress(email);
            const string fromPassword = "your-email-password";
            const string subject = "Đặt lại mật khẩu";
            string body = $"Mã xác nhận của bạn để đặt lại mật khẩu là: {resetCode}";

            var smtp = new SmtpClient
            {
                Host = "smtp.example.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        [HttpGet]
        public IActionResult ResetPassword(string resetCode)
        {
            var account = _context.Accounts.FirstOrDefault(u => u.ResetPasswordCode == resetCode);
            if (account != null)
            {
                ViewBag.ResetCode = resetCode;
                return View();
            }
            else
            {
                return Content("Mã xác nhận không hợp lệ. Vui lòng thử lại.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(string resetCode, string newPassword)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(u => u.ResetPasswordCode == resetCode);
            if (account != null)
            {
                // Băm mật khẩu mới
                MD5 md5 = MD5.Create();
                byte[] passBytes = Encoding.UTF8.GetBytes(newPassword);
                byte[] hashBytes = md5.ComputeHash(passBytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                string hashedPassword = builder.ToString();

                // Cập nhật mật khẩu mới vào cơ sở dữ liệu
                account.Password = hashedPassword;
                account.ResetPasswordCode = null; // Xóa mã reset password sau khi đã sử dụng
                _context.Update(account);
                await _context.SaveChangesAsync();

                return Content("Mật khẩu của bạn đã được đổi thành công.");
            }
            else
            {
                return Content("Đổi mật khẩu không thành công. Mã xác nhận không hợp lệ.");
            }
        }
        public IActionResult Loginktr(string username, string password)
        {
            // Băm mật khẩu người dùng nhập vào
            MD5 md5 = MD5.Create();
            byte[] passBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(passBytes);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            string hashedPassword = builder.ToString();

            // So sánh với mật khẩu đã băm trong cơ sở dữ liệu
            var user = _context.Accounts.FirstOrDefault(u => u.UserName == username && u.Password == hashedPassword);

            if (user != null)
            {
                if (user.Role == "Admin")
                {
                    HttpContext.Session.SetString("LoggedInUser", user.UserName);
                    return RedirectToAction(nameof(Index));
                }
                else if (user.Role == "Member")
                {
                    HttpContext.Session.SetString("LoggedInUser", user.UserName);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMessage = "Tài khoản đã bị vô hiệu hóa";
                    return View("Login");
                }
            }
            else
            {
                // Set a ViewBag to show the error message
                ViewBag.ErrorMessage = "Tài khoản hoặc mật khẩu không đúng";
                return View("Login");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction(nameof(Index), "Home");
        }
        public IActionResult TTKH()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("LoggedInUser")))
            {
                // Lấy tên người dùng đã đăng nhập từ Session
                var loggedInUsername = HttpContext.Session.GetString("LoggedInUser");
                // Lấy thông tin người dùng từ cơ sở dữ liệu
                var user = _context.Accounts.FirstOrDefault(u => u.UserName == loggedInUsername);
                if (user != null)
                {
                    return View(user);
                }
            }
            // Nếu người dùng chưa đăng nhập, chuyển hướng về trang đăng nhập
            return RedirectToAction("Login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
