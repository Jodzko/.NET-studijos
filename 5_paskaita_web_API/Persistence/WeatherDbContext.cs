using _5_paskaita_web_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _5_paskaita_web_API.Persistence
{
    public class WeatherDbContext : DbContext

    {
        public DbSet<WeatherData> Weathers { get; set; }

        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options)
        {

        }
    }
}
