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
                    return View("Index");
                }
                else if (user.Role == "Member")
                {
                    HttpContext.Session.SetString("LoggedInUser", user.UserName);
                    return View("Index");
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
