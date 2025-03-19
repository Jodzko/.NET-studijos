using _2_paskaita_web_API.Requests;


namespace _2_paskaita_web_API.Services
{
    public class OrderService : IOrderService
    {
        private readonly IConsoleLogger _logger;
        private readonly ISqlRepository _repository;
        private readonly IEmailNotificationService _notificationService;

        public OrderService(IConsoleLogger logger,
                            ISqlRepository repository,
                            IEmailNotificationService notificationService)
        {
            _logger = logger;
            _repository = repository;
            _notificationService = notificationService;
        }

        public void PlaceOrder(OrderRequest order)
        {
            _logger.Log($"Placing order {order.Name}...");
            _repository.SaveOrder(order.Name);
            _notificationService.SendNotification($"Order {order.Name} has been placed!");
            _logger.Log($"Order {order.Name} has been processed successfully.");
        }
    }
}
