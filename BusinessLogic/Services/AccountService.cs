using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Database.Models;
using _web_api_project.Database.Persistence;
using _web_api_project.Database.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepo)
        {
            _accountRepository = accountRepo;
        }
        public bool SignupNewAccount(string username, string password)
        {
            var existingAccount = _accountRepository.FindAccountInDatabase(username);
            if (existingAccount != null)
            {
                return false;
            }
            else
            {
                var account = CreateAccount(username, password);
                _accountRepository.AddAcountToDatabase(account);                
                return true;
            }
        }
        public Account CreateAccount(string username, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            var account = new Account
            {
                Username = username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
            };
            return account;
        }
        public bool Login(string username, string password)
        {
            var account = _accountRepository.FindAccountInDatabase(username);

            if (account == null)
            {
                return false;
            }
            if (VerifyPasswordHash(password, account.PasswordHash, account.PasswordSalt))
            {
                return true;
            }
            return false;
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }
}
