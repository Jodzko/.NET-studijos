using _web_api_images.Models;

namespace _web_api_images.Persistence
{
    public interface IImageRepository
    {
        public void UploadImage(Image image);

        public Image DownloadImage(int id);
    }
}
