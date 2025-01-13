namespace Mongo_DB
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Page> Pages { get; set; }

        public Book(int id, string name)
        {
            Id = id;
            Name = name;
            Pages = new List<Page>();
        }
    }
}
