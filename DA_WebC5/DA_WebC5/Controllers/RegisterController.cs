using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DA_WebC5.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RegisterController(ApplicationDbContext context) => _context = context;

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Account account, string passConfirm)
        {
            var accDb = _context.Accounts.FirstOrDefault(x => x.UserName == account.UserName);
            if (accDb != null)
            {
                ModelState.AddModelError("UserName", "Tên tài khoản đã tồn tại");
                return View(account);
            }
            else if (account.Password != passConfirm)
            {
                ViewData["Error"] = "Mật khẩu xác nhận không trùng khớp";
                return View(account);
            }
            else
            {
                MD5 md5 = MD5.Create();
                byte[] pass = Encoding.UTF8.GetBytes(account.Password);
                byte[] hash = md5.ComputeHash(pass);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                TempData["password"] = builder.ToString();
                TempData["username"] = account.UserName;
                return RedirectToAction(nameof(NextRegister));
            }
        }


        public IActionResult NextRegister()
        {
            string username = TempData["username"] as string;
            string password = TempData["password"] as string;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Register");
            }
            var account = new Account()
            {
                UserName = username,
                Password = password
            };
            return View(account);
        }

        [HttpPost]
        public IActionResult NextRegister(Account account)
        {
            if (ModelState.IsValid)
            {
                var emailExist = _context.Accounts.FirstOrDefault(x => x.Email == account.Email);
                if (emailExist != null)
                {
                    ModelState.AddModelError("Email", "Email đã tồn tại");
                    return View(account);
                }
                _context.Accounts.Add(account);
                _context.SaveChanges();
                HttpContext.Session.SetString("LoggedInUser", account.UserName);
                return RedirectToAction(nameof(Index), "Home");
            }
            return View(account);
        }
    }
}
