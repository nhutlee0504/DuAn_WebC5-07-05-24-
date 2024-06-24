using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace DA_WebC5.Controllers
{
    public class ForgotController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public ForgotController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string Email)
        {
            if (ModelState.IsValid)
            {
                var account = await _context.Accounts.SingleOrDefaultAsync(a => a.Email == Email);

                if (account != null)
                {
                    var code = GenerateConfirmationCode();
                    var message = $"Mật khẩu mới của bạn là: <strong>{code}</strong>";

                    await SendEmailAsync(account.Email, "Mật khẩu mới", message);

                    MD5 md5 = MD5.Create();
                    byte[] passBytes = Encoding.UTF8.GetBytes(code);
                    byte[] hashBytes = md5.ComputeHash(passBytes);
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        builder.Append(hashBytes[i].ToString("x2"));
                    }
                    account.Password = builder.ToString();
                    _context.SaveChanges();
                    ViewBag.IsEmailSent = true;
                    ViewBag.Email = Email;
                    ViewBag.Message = "Mật khẩu mới đã được gửi đến Email của bạn";
                }
                else
                {
                    ModelState.AddModelError("Email", "Email không tồn tại trong hệ thống");
                    ViewBag.Email = Email;
                }
            }

            return View();
        }

        private async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(_configuration["EmailSettings:SenderName"], _configuration["EmailSettings:SenderEmail"]));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("html") { Text = message };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_configuration["EmailSettings:MailServer"],
                                          int.Parse(_configuration["EmailSettings:MailPort"]),
                                          MailKit.Security.SecureSocketOptions.StartTls);

                await client.AuthenticateAsync(_configuration["EmailSettings:Username"], _configuration["EmailSettings:Password"]);

                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }

        private string GenerateConfirmationCode()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
