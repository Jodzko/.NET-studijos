using _3_paskaita_web_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _3_paskaita_web_API.Persistence
{
    public class AccountDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {
        }

    }
}
