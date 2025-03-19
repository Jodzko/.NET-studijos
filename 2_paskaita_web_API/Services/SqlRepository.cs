using Microsoft.AspNetCore.DataProtection.Repositories;

namespace _2_paskaita_web_API.Services
{
    public class SqlRepository : ISqlRepository
    {
        private readonly IConsoleLogger _logger;

        public SqlRepository(IConsoleLogger logger)
        {
            _logger = logger;
        }

        public void SaveOrder(string orderId)
        {
            _logger.Log($"Saving order {orderId} to SQL database...");
            _logger.Log($"Order {orderId} saved successfully.");
        }
    }

}
