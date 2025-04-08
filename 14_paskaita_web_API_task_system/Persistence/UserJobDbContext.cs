using _14_paskaita_web_API_task_system.Models;
using Microsoft.EntityFrameworkCore;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public class UserJobDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public UserJobDbContext(DbContextOptions<UserJobDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Jobs)
                .WithMany(s => s.Users)
                .UsingEntity(j => j.ToTable("UsersJobs"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
