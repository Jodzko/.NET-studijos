using _2_paskaita_web_API.Requests;


namespace _2_paskaita_web_API.Services
{
    public interface IOrderService
    {
        void PlaceOrder(OrderRequest order);
    }
}
