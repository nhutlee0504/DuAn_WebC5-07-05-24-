using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
    
        [Route("Admin/Index")]
        public IActionResult Index()
        {
            var username = HttpContext.Session.GetString("LoggedInUser");
            var role = _context.Accounts.Where(x => x.UserName == username).Select(x => x.Role);
            if (!role.Contains("Admin"))
            {
                Logout();
                return RedirectToAction("Loginktr");
            }
            else if (string.IsNullOrEmpty(username))
            {
                return View("Loginktr");
            }
            return View();
        }
        [Route("Admin/Loginktr")]
        public IActionResult Loginktr()
        {
            return View();
        }
        [Route("Admin/Loginktr")]
        [HttpPost]
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
                    return RedirectToAction("Index", "Home", new { area = "Admin" });

                }

                else
                {
                    ViewBag.ErrorMessage = "Tài khoản không có quyền truy cập";
                    return View("Loginktr");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Tài khoản hoặc mật khẩu không đúng";
                return View("Loginktr");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            //HttpContext.SignOutAsync();
            return RedirectToAction("Loginktr", "Home", new {area = "Admin"});
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
