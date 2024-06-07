using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Data;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccount account;
        public AccountController(IAccount acc) => account = acc;

        [HttpGet]
        public IEnumerable<Account> GetAll()
        {
            return account.GetAccounts();
        }

        [HttpPost]
        public Account Add(Account acc)
        {
            return account.AddAccount(new Account
            {
                UserName = acc.UserName,
                Password = acc.Password,
                Email = acc.Email,
                Role = acc.Role,
                Address = acc.Address,
                Phone = acc.Phone,
                Gender = acc.Gender,
                Name = acc.Name
            });
        }

        [HttpGet("{user}")]
        public Account GetUser(string user)
        {
            if (string.IsNullOrEmpty(user))
                return null;
            return account.GetAccountById(user);
        }

        [HttpPut("{user}")]
        public Account Update(Account acc, string user)
        {
            if (string.IsNullOrEmpty(user))
                return null;
            return account.UpdateAccount(user, acc);
        }

        [HttpDelete("{user}")]
        public IActionResult Delete(string user)
        {
            if (string.IsNullOrEmpty(user))
                return null;
            account.DeleteAccount(user);     
            return NoContent();
        }
    }
}
