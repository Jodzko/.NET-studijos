using _web_api_images.Models;

namespace _web_api_images.Persistence
{
    public interface IThumbnailRepository
    {
        public void UploadThumbnail(Thumbnail image);
        public Thumbnail DownloadThumbnail(int id);

    }
}
