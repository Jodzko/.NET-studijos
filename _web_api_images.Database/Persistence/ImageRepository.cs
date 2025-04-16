using _web_api_images.Models;

namespace _web_api_images.Persistence
{
    public class ImageRepository : IImageRepository
    {
        private readonly ImageDbContext _context;
        public ImageRepository(ImageDbContext context)
        {
            _context = context;
        }
        public void UploadImage(Image image)
        {
            _context.Add(image);
            _context.SaveChanges();
        }
        public Image DownloadImage(int id)
        {
            return _context.Images.FirstOrDefault(x => x.Id == id);
        }
    }
}
