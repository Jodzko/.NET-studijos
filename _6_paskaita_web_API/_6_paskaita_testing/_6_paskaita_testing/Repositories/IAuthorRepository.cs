using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Repositories
{
    public interface IAuthorRepository
    {
        Author? GetById(int id);
        IEnumerable<Author> GetAll();
        Author Add(Author author);
        Author Update(Author author);
        bool Delete(int id);
    }
}
