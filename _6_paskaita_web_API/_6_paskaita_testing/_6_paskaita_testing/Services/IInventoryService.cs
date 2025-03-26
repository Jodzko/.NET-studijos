namespace _6_paskaita_testing.Services
{
    public interface IInventoryService
    {
        bool AreBooksInStock(List<int> bookIds);
    }
}
