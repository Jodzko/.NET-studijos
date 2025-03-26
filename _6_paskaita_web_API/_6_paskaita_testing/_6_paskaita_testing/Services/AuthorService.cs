using _6_paskaita_testing.Models;
using _6_paskaita_testing.Repositories;

namespace _6_paskaita_testing.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepo;

        public AuthorService(IAuthorRepository authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public Author CreateAuthor(Author author)
        {
            return _authorRepo.Add(author);
        }

        public bool DeleteAuthor(int id)
        {
            return _authorRepo.Delete(id);
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _authorRepo.GetAll();
        }

        public Author? GetAuthor(int id)
        {
            return _authorRepo.GetById(id);
        }

        public Author? UpdateAuthor(Author author)
        {
            var existing = _authorRepo.GetById(author.Id);
            if (existing == null) return null;

            return _authorRepo.Update(author);
        }
    }

}
