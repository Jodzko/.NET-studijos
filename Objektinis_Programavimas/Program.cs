using Objektinis_Programavimas;
using System.Net.Sockets;
using System.Reflection;

//Person person1 = new Person("Artur", 29, 1.83);
//Console.WriteLine(person1.Name);
//Console.WriteLine(person1.Age);
//Console.WriteLine(person1.Height);
//School school1 = new School("Radvilu", "Vilnius", 250);
//Console.WriteLine(school1.Name);
//Console.WriteLine(school1.City);
//Console.WriteLine(school1.StudentCount);



var book1 = new Book("Harry Potter and the Prizoner of Azkaban", "J.K. Rowling", "1999.07.08", "Great Britain");
var book2 = new Book("Harry Potter and the Goblet of Fire", "J.K. Rowling", "2000.05.25", "Great Britain");
var book3 = new Book("Moby-Dick", "Herman Melville", "1851.10.18", "U.S.A.");
var book4 = new Book("Harry Potter and the Philosophers 'Stone", "J.K. Rowling", "1997.06.26", "Great Britain");
var author = "J.K. Rowling";
List<Book> books = new List<Book>()
{
    book1,
    book2,
    book3,
    book4
};
var booksByThisAuthor = FindAuthor(books, author);
//foreach (var item in booksByThisAuthor)
//{
//    Console.WriteLine(item);
//}

static List<string> FindAuthor(List<Book> allBooks, string author)
{
    var booksByThisAuthor = new List<string>();
    foreach (var book in allBooks)
    {
        if(book.Author == author)
        {
            booksByThisAuthor.Add(book.Name);
        }
    }
    
    return booksByThisAuthor;
}


Address person1Address = new Address();
person1Address.City = "Vilnius";
person1Address.Street = "Seskines";

var person1 = new Person1("Tomas", 35, person1Address);
Console.WriteLine(person1.Name);
Console.WriteLine(person1.Age);
Console.WriteLine(person1.Address.City);
Console.WriteLine(person1.Address.Street);

