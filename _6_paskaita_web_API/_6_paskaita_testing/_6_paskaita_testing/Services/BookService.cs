using _6_paskaita_testing.Models;
using _6_paskaita_testing.Repositories;

namespace _6_paskaita_testing.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepo;

        public BookService(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public Book CreateBook(Book book)
        {
            return _bookRepo.Add(book);
        }

        public bool DeleteBook(int id)
        {
            return _bookRepo.Delete(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepo.GetAll();
        }

        public Book? GetBook(int id)
        {
            return _bookRepo.GetById(id);
        }

        public Book? UpdateBook(Book book)
        {
            var existing = _bookRepo.GetById(book.Id);
            if (existing == null) return null;
            return _bookRepo.Update(book);
        }
    }

}
