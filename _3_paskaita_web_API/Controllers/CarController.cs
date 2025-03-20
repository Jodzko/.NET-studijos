using _3_paskaita_web_API.Models;
using _3_paskaita_web_API.Persistence;
using _3_paskaita_web_API.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_paskaita_web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarDatabase _carDatabase;
        private readonly ILogger<CarController> _logger;

        public CarController(ICarDatabase cardatabase, ILogger<CarController> logger)
        {
            _logger = logger;
            _carDatabase = cardatabase;
        }

        [HttpPost]
        public ActionResult AddCar([FromBody] CarRequest request)
        {
            _carDatabase.AddCar(request);
            return Ok();
        }

        [HttpGet]
        public ActionResult GetCars()
        {
            _logger.LogWarning("Something went wrong");
            return Ok(_carDatabase.Cars());
        }

        [HttpGet("Color")]
        public ActionResult ByColor([FromQuery] string color)
        {
            return Ok(_carDatabase.ByColor(color));
        }
        [HttpPut]
        public ActionResult Update([FromBody] CarRequest request, [FromQuery] Guid id)
        {
            _carDatabase.Update(request, id);
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(Guid id)
        {
            _carDatabase.Delete(id);
            return Ok();
        }
    }
}
