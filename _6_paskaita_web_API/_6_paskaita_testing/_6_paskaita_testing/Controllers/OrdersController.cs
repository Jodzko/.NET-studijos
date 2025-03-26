using _6_paskaita_testing.Models;
using _6_paskaita_testing.Services;
using Microsoft.AspNetCore.Mvc;

namespace _6_paskaita_testing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return Ok(_orderService.GetAllOrders());
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetById(int id)
        {
            var order = _orderService.GetOrder(id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpPost]
        public ActionResult<Order> Create([FromBody] List<int> bookIds)
        {
            try
            {
                var newOrder = _orderService.CreateOrder(bookIds);
                return CreatedAtAction(nameof(GetById), new { id = newOrder.Id }, newOrder);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("{id}/pay")]
        public IActionResult Pay(int id)
        {
            var success = _orderService.PayForOrder(id);
            if (!success) return BadRequest("Payment failed or order not found.");
            return Ok("Payment successful.");
        }
    }
}
