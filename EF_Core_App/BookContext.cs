using Microsoft.EntityFrameworkCore;

namespace EF_Core_App
{
    public class BookContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EF_Core;Trusted_Connection=True;");
        }
    }
}
