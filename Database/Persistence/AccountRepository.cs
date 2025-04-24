using _web_api_project.Database.Models;
using _web_api_project.Database.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.Database.Persistence
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AppDbContext _context;

        public AccountRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddAcountToDatabase(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public Account FindAccountInDatabase(string username)
        {
            return _context.Accounts.FirstOrDefault(x => x.Username == username);
        }
    }
}
