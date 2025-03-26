using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Services
{
    public interface IBookService
    {
        Book? GetBook(int id);
        IEnumerable<Book> GetAllBooks();
        Book CreateBook(Book book);
        Book? UpdateBook(Book book);
        bool DeleteBook(int id);
    }
}
