using Microsoft.AspNetCore.Mvc;
using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class AccountResponse : IAccount
    {
        private readonly ApplicationDbContext context;
        public AccountResponse(ApplicationDbContext ct)
        {
            context = ct;
        }
        public Account AddAccount(Account account)
        {
            try
            {
                context.Accounts.Add(account);
                context.SaveChanges();
                return account;
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public void DeleteAccount(string user)
        {
            var us = context.Accounts.Find(user);
            if (us != null)
            {
                context.Accounts.Remove(us);
                context.SaveChanges();
            }
        }

        public Account GetAccountById(string user)
        {
            return context.Accounts.Find(user);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return context.Accounts;
        }

        public Account UpdateAccount(string user, Account account)
        {
            try
            {
                var us = context.Accounts.Find(user);
                if (us != null)
                {
                    us.Password = account.Password;
                    us.Email = account.Email;
                    us.Role = account.Role;
                    us.Name = account.Name;
                    us.Gender = account.Gender;
                    us.Phone = account.Phone;
                    us.Address = account.Address;
                    context.SaveChanges();
                    return account;
                }
                return null;
            }
            catch (System.Exception)
            {

                return null;
            }
        }
    }
}
