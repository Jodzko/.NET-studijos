using _web_api_images.Contracts;
using _web_api_images.Models;
using _web_api_images.Persistence;
using _web_api_images.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _web_api_images.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _service;
        private readonly IThumbnailRepository _thumbRepo;
        public ImageController(IImageService service, IThumbnailRepository thumbRepo)
        {
            _service = service;
            _thumbRepo = thumbRepo;
        }
        [HttpPost("Upload")]
        public IActionResult UploadImage([FromForm] ImageUploadRequest request)
        {
            _service.UploadImage(request);
            return Ok();
        }

        [HttpGet("Download Full Image")]
        public IActionResult DownloadImage([FromQuery] int id)
        {
            var image = _service.DownloadImage(id);
            return File(image.Bytes, $"image/{image.Extension}");
        }
        [HttpGet("Download Thumbnail")]
        public IActionResult DownloadThumbnail([FromQuery] int id)
        {
            var image = _thumbRepo.DownloadThumbnail(id);
            return File(image.ThumbnailBytes, $"image/Jpeg");
        }
    }
}
