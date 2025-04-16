using _web_api_images.Models;
using Microsoft.EntityFrameworkCore;

namespace _web_api_images.Persistence
{
    public class ImageDbContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<Thumbnail> Thumbnails { get; set; }
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {

        }

    }
}
