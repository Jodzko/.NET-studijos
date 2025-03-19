using _2_paskaita_web_API.Services;
using _2_paskaita_web_API.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2_paskaita_web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public ActionResult PlaceOrder([FromBody] OrderRequest request)
        {
            _orderService.PlaceOrder(request);
            return Ok();
        }
        [HttpGet]
        public ActionResult GetJoke()
        {
            string joke = "";
            return Ok(joke);
        }
    }
}
