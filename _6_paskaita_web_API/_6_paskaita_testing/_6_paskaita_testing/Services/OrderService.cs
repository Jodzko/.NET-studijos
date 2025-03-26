using _6_paskaita_testing.Models;
using _6_paskaita_testing.Repositories;

namespace _6_paskaita_testing.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IBookRepository _bookRepo;
        private readonly IInventoryService _inventoryService;
        private readonly IPaymentService _paymentService;

        public OrderService(IOrderRepository orderRepo,
                            IBookRepository bookRepo,
                            IInventoryService inventoryService,
                            IPaymentService paymentService)
        {
            _orderRepo = orderRepo;
            _bookRepo = bookRepo;
            _inventoryService = inventoryService;
            _paymentService = paymentService;
        }

        public Order CreateOrder(List<int> bookIds)
        {
            // Check if books are in stock
            if (!_inventoryService.AreBooksInStock(bookIds))
                throw new System.Exception("One or more books are not in stock.");

            // Calculate total price
            var books = _bookRepo.GetAll().Where(b => bookIds.Contains(b.Id)).ToList();
            var total = books.Sum(b => b.Price);

            // Create new order
            var newOrder = new Order
            {
                BookIds = bookIds,
                TotalAmount = total,
                IsPaid = false
            };
            return _orderRepo.Add(newOrder);
        }

        public IEnumerable<Order> GetAllOrders() => _orderRepo.GetAll();

        public Order? GetOrder(int id) => _orderRepo.GetById(id);

        public bool PayForOrder(int orderId)
        {
            var order = _orderRepo.GetById(orderId);
            if (order == null) return false;
            if (order.IsPaid) return true; // already paid

            var success = _paymentService.ProcessPayment(order.TotalAmount);
            if (success)
            {
                order.IsPaid = true;
                _orderRepo.Update(order);
            }
            return success;
        }
    }
}
