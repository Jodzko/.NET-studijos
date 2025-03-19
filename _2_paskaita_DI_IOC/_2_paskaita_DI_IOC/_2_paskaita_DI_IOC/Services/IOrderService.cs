using _2_paskaita_DI_IOC.Requests;

namespace _2_paskaita_DI_IOC.Services
{
    public interface IOrderService
    {
        void PlaceOrder(OrderRequest order);
    }
}
