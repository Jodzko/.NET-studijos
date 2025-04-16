namespace _web_api_images.Models
{
    public class Thumbnail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] ThumbnailBytes { get; set; }
        public Image OriginalImage { get; set; }
    }
}
