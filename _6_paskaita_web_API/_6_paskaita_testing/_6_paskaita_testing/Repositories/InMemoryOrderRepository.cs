using _6_paskaita_testing.Models;

namespace _6_paskaita_testing.Repositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>();
        private int _nextId = 1;

        public Order Add(Order order)
        {
            order.Id = _nextId++;
            _orders.Add(order);
            return order;
        }

        public IEnumerable<Order> GetAll() => _orders;

        public Order? GetById(int id) => _orders.FirstOrDefault(o => o.Id == id);

        public Order Update(Order order)
        {
            var existing = _orders.FirstOrDefault(o => o.Id == order.Id);
            if (existing == null) return null!;

            existing.BookIds = order.BookIds;
            existing.TotalAmount = order.TotalAmount;
            existing.IsPaid = order.IsPaid;
            return existing;
        }
    }

}
