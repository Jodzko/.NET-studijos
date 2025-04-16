namespace _web_api_images.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
        public byte[] Bytes { get; set; }

    }
}
