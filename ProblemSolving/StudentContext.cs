using Microsoft.EntityFrameworkCore;

namespace DB_Atsiskaitymas
{
    public class StudentContext : DbContext
    {
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer($"Data Source=.;Server=localhost\\SQLEXPRESS;Database=ProblemSolving;Trusted_Connection=True;")
            .EnableSensitiveDataLogging();
        }
    }
}