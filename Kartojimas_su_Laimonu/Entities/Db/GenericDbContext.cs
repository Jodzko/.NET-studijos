using Microsoft.EntityFrameworkCore;

namespace Kartojimas_su_Laimonu.Entities
{
    public class GenericDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer($"Data Source=.;Server=localhost\\SQLEXPRESS;Database=Kartojimas_su_Laimonu;Trusted_Connection=True;TrustServerCertificate=True;")
            .EnableSensitiveDataLogging();
        }
    }
}
