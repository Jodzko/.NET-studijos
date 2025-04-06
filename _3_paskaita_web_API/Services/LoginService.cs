//using _11_paskaita_JWT.Models;
using _3_paskaita_web_API.Models;
using _3_paskaita_web_API.Persistence;
using System.Net.WebSockets;
using System.Security.Cryptography;

namespace _11_paskaita_JWT.Services
{
    public class LoginService : ILoginService
    {
        private readonly IJwtService _jwtService;
        private readonly AccountDbContext _context;
        public LoginService(IJwtService jwtService, AccountDbContext accountDatabase)
        {
            _jwtService = jwtService;
            _context = accountDatabase;
        }

        public bool SignupNewAccount(string username, string password)
        {
            // turetu patikrint ar tokio vartotojo nera
            var existingAccount = _context.Accounts.SingleOrDefault(x => x.Username == username);
            if(existingAccount != null) 
            {
                return false;
            }
            else
            {
            var account = CreateAccount(username, password);
            _context.Accounts.Add(account);
            _context.SaveChanges();
            // neturetu grazinti viso account, gal uztektu true/false arba iskarto sugeneruota JWT
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
                Role = "User"
            };
            return account;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        public bool Login(string username, string password, out string role)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.Username == username);

            if(account == null)
            {
                role = string.Empty;
                return false;
            }
            role = account.Role;
            if(VerifyPasswordHash(password, account.PasswordHash, account.PasswordSalt))
            {
                return true;
            }
            return false;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }
}
