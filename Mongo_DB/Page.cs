namespace Mongo_DB
{
    public class Page
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public Page(int id, string content)
        {
            Id = id;
            Content = content;
        }
    }
}
