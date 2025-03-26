using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Repositories
{
    public interface IOrderRepository
    {
        Order? GetById(int id);
        IEnumerable<Order> GetAll();
        Order Add(Order order);
        Order Update(Order order);
    }

}
