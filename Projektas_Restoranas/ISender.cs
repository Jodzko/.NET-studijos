namespace Projektas_Restoranas
{
    public interface ISender
    {
        public void SendRestaurantReceipt(Order order, Waiter waiter);
        public void SendCustomerReceipt(Order order, Waiter waiter);
    }
}
