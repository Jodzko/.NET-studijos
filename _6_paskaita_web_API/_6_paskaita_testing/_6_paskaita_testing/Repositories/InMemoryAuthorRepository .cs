using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Repositories
{
    public class InMemoryAuthorRepository : IAuthorRepository
    {
        private readonly List<Author> _authors = new List<Author>();
        private int _nextId = 1;

        public Author Add(Author author)
        {
            author.Id = _nextId++;
            _authors.Add(author);
            return author;
        }

        public bool Delete(int id)
        {
            var author = _authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return false;
            _authors.Remove(author);
            return true;
        }

        public IEnumerable<Author> GetAll() => _authors;
        public Author? GetById(int id) => _authors.FirstOrDefault(a => a.Id == id);

        public Author Update(Author author)
        {
            var existing = _authors.FirstOrDefault(a => a.Id == author.Id);
            if (existing == null) return null!;

            existing.FullName = author.FullName;
            existing.DateOfBirth = author.DateOfBirth;
            return existing;
        }
    }

}
