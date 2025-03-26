using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Repositories
{
    public interface IBookRepository
    {
        Book? GetById(int id);
        IEnumerable<Book> GetAll();
        Book Add(Book book);
        Book Update(Book book);
        bool Delete(int id);

    }
}
