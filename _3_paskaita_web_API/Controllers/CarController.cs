using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_paskaita_web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarDatabase _carDatabase;
        
        public CarController(ICarDatabase cardatabase)
        {
            _carDatabase = cardatabase;
        }

        [HttpPost]
        public ActionResult AddCar([FromBody] Car car)
        {
            _carDatabase.AddCar(car);
            return Ok();
        }

        [HttpGet]
        public ActionResult GetCars()
        {
            return Ok(_carDatabase.Cars());
        }

        [HttpGet("byColor")]
        public ActionResult ByColor([FromQuery] string color)
        {
            return Ok(_carDatabase.ByColor(color));
        }
        [HttpPut]
        public ActionResult Update([FromQuery] Guid id, [FromBody] Car car)
        {
            _carDatabase.Update(id, car);
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
