using _web_api_images.Contracts;
using _web_api_images.Models;

namespace _web_api_images.Services.Interfaces
{
    public interface IImageService
    {
        public void UploadImage(ImageUploadRequest imageUploadRequest);
        public Image DownloadImage(int id);
    }
}
