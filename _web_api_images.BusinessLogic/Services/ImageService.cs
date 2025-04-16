using _web_api_images.Contracts;
using _web_api_images.Models;
using _web_api_images.Persistence;
using _web_api_images.Services.Interfaces;
using Azure.Core;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
namespace _web_api_images.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _repository;
        private readonly IThumbnailRepository _thumbRepo;

        public ImageService(IImageRepository repository, IThumbnailRepository thumbRepo)
        {
            _repository = repository;
            _thumbRepo = thumbRepo;
        }

        public Models.Image DownloadImage(int id)
        {
            return _repository.DownloadImage(id);
        }

        public void UploadImage(ImageUploadRequest request)
        {
            using var ms = new MemoryStream();
            request.Image.CopyTo(ms);

            var imageBytes = ms.ToArray();

            var extension = Path.GetExtension(request.Image.FileName);

            var entity = new Models.Image
            {
                Name = request.Image.FileName,
                Extension = extension,
                Size = request.Image.Length,
                Bytes = imageBytes
            };
            var thumbnail = new Thumbnail
            {
                Name = $"{entity.Name} Thumbnail",
                OriginalImage = entity,
                ThumbnailBytes = CreateThumbnail(entity.Bytes)
            };
            _thumbRepo.UploadThumbnail(thumbnail);
            //_repository.UploadImage(entity);
        }
        public byte[] CreateThumbnail(byte[] imageBytes)
        {
            using var inputStream = new MemoryStream(imageBytes);
            using var originalImage = System.Drawing.Image.FromStream(inputStream);

            int thumbWidth = 150;
            int thumbHeight = 150;

            using var thumbnail = originalImage.GetThumbnailImage(thumbWidth, thumbHeight, () => false, IntPtr.Zero);
            using var ms = new MemoryStream();
            thumbnail.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
