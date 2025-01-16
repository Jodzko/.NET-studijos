using Microsoft.EntityFrameworkCore;

namespace Many_to_many_code_first
{
    public class FileContext : DbContext
    {
        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=.;Server=localhost\\SQLEXPRESS;Database=CodeAcademyStudying;Trusted_Connection=True;");
        }
    }
}
