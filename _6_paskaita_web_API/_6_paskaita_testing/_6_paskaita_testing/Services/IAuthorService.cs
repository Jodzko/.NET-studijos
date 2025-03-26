using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Services
{
    public interface IAuthorService
    {
        Author? GetAuthor(int id);
        IEnumerable<Author> GetAllAuthors();
        Author CreateAuthor(Author author);
        Author? UpdateAuthor(Author author);
        bool DeleteAuthor(int id);
    }
}
