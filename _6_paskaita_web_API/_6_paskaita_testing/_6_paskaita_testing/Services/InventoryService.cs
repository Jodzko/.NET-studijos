using _6_paskaita_testing.Repositories;

namespace _6_paskaita_testing.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IBookRepository _bookRepo;

        public InventoryService(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public bool AreBooksInStock(List<int> bookIds)
        {
            return bookIds.All(id => _bookRepo.GetById(id) != null);
        }
    }
}
