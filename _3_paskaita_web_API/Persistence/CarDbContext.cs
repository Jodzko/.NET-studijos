using _3_paskaita_web_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _3_paskaita_web_API.Persistence
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {
        }

    }
}
