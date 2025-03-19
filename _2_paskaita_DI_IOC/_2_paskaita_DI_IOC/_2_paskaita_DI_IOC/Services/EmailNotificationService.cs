namespace _2_paskaita_DI_IOC.Services
{
    public class EmailNotificationService : IEmailNotificationService
    {
        private readonly IConsoleLogger _logger;

        public EmailNotificationService(IConsoleLogger logger)
        {
            _logger = logger;
        }

        public void SendNotification(string message)
        {
            _logger.Log($"Sending email notification: {message}");
            _logger.Log("Email sent successfully.");
        }
    }
}
