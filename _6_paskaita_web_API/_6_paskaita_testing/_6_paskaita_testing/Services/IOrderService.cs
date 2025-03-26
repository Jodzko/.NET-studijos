using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Services
{
    public interface IOrderService
    {
        Order? GetOrder(int id);
        IEnumerable<Order> GetAllOrders();
        Order CreateOrder(List<int> bookIds);
        bool PayForOrder(int orderId);
    }
}
