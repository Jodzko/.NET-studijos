using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Repositories
{
    public class InMemoryBookRepository : IBookRepository
    {
        private readonly List<Book> _books = new List<Book>();
        private int _nextId = 1;

        public Book Add(Book book)
        {
            book.Id = _nextId++;
            _books.Add(book);
            return book;
        }

        public bool Delete(int id)
        {
            var book = _books.FirstOrDefault(x => x.Id == id);
            if (book == null) return false;
            _books.Remove(book);
            return true;
        }

        public IEnumerable<Book> GetAll() => _books;

        public Book? GetById(int id) => _books.FirstOrDefault(x => x.Id == id);

        public Book Update(Book book)
        {
            var existing = _books.FirstOrDefault(x => x.Id == book.Id);
            if (existing == null) return null!;

            existing.Title = book.Title;
            existing.ISBN = book.ISBN;
            existing.Price = book.Price;
            existing.AuthorId = book.AuthorId;

            return existing;
        }
    }
}
