namespace _6_paskaita_testing.Services
{
    public class PaymentService : IPaymentService
    {
        public bool ProcessPayment(decimal amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Payment of {amount} processed.");
                return true;
            }
            return false;
        }
    }
}
