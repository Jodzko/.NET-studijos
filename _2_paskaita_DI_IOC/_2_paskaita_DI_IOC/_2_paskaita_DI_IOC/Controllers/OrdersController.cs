using _2_paskaita_DI_IOC.Requests;
using _2_paskaita_DI_IOC.Services;
using Microsoft.AspNetCore.Mvc;

namespace _2_paskaita_DI_IOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public ActionResult PlaceOrder([FromBody] OrderRequest request)
        {
            _orderService.PlaceOrder(request);
            return Ok();
        }
    }
}
