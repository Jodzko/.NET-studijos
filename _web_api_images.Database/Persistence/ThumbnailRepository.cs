using _web_api_images.Models;

namespace _web_api_images.Persistence
{
    public class ThumbnailRepository : IThumbnailRepository
    {
        private readonly ImageDbContext _context;
        public ThumbnailRepository(ImageDbContext context)
        {
            _context = context;
        }
        public void UploadThumbnail(Thumbnail image)
        {
            _context.Add(image);
            _context.SaveChanges();
        }
        public Thumbnail DownloadThumbnail(int id)
        {
            return _context.Thumbnails.FirstOrDefault(x => x.Id == id);
        }
    }
}
