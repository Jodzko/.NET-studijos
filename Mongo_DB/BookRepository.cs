using MongoDB.Driver;
using System.Xml.Linq;

namespace Mongo_DB
{
    public class BookRepository
    {
        public MongoClient client = new MongoClient("mongodb+srv://ajodzko:zQjt7CiMAEAPw1gv@cluster0.7govy.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
        public List<Book> Books { get; set; }
        public BookRepository()
        {
            Books = new List<Book>();
        }


        public void AddBook(Book book)
        {            
            var bookCollection = client.GetDatabase("BookRepository").GetCollection<Book>("bookRepository");
            Books.Add(book);
            bookCollection.InsertOne(book);
        }

        public void UpdateRepository(string fieldName)
        {
            var bookCollection = client.GetDatabase("BookRepository").GetCollection<Book>("bookRepository");
            var filter = Builders<Book>.Filter.Eq("Name", fieldName);
            var update = Builders<Book>.Update.AddToSet("Pages", new Page(5, "New page content"));
            bookCollection.UpdateMany(filter, update);

        }
        public void DeleteBook(string name )
        {
            var bookCollection = client.GetDatabase("BookRepository").GetCollection<Book>("bookRepository");
            var filter = Builders<Book>.Filter.Eq("Name", name);
            bookCollection.DeleteOne(filter);

        }
        public void FindBook(string name)
        {
            var bookCollection = client.GetDatabase("BookRepository").GetCollection<Book>("bookRepository");
            var filter = Builders<Book>.Filter.Eq("Name", name);
            var result = bookCollection.Find(filter).ToList();

        }
    }
}
