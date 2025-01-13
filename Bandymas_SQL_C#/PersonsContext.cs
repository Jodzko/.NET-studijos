using Microsoft.EntityFrameworkCore;

namespace Bandymas_SQL_C_
{
    public class PersonsContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<TournamentTable> Tables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MyTestDB;Trusted_Connection=True;");
        }
    }
}
