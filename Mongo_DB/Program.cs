using Mongo_DB;
using MongoDB.Driver;

//MongoClient client = new MongoClient("mongodb+srv://ajodzko:zQjt7CiMAEAPw1gv@cluster0.7govy.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
//var bookCollection = client.GetDatabase("Books").GetCollection<Book>("book");

//var book1 = new Book(1, "The great Gatsby");

var page1 = new Page(1, "This the first entry");
var page2 = new Page(2, "This the second entry");
var page3 = new Page(3, "This the third entry");

var pagesOfTheBook = new List<Page>
{
    page1,
    page2,
    page3
};
//book1.Pages = pagesOfTheBook;

//var filter = Builders<Book>.Filter.Eq("Name", "The great Gatsby");

//var result = bookCollection.Find(filter).ToList();



var repository = new BookRepository();

//var newBook = new Book(1, "The great Gatsby");
//newBook.Pages = pagesOfTheBook;

//repository.AddBook(newBook);
//repository.FindBook("The great Gatsby");

repository.UpdateRepository("The great Gatsby");


//repository.DeleteBook("Moby Dick");


Console.WriteLine();


