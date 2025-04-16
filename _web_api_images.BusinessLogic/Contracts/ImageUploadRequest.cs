using _web_api_images.ValidationAttributes;
using Microsoft.AspNetCore.Http;

namespace _web_api_images.Contracts
{
    public class ImageUploadRequest
    {
        [MaxFileSize(5 * 1024 * 1024)]
        [AllowedExtensions([".png", ".jpg"])]
        public IFormFile Image { get; set; }
    }
}
