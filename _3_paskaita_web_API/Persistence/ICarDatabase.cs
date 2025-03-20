using _3_paskaita_web_API.Models;
using _3_paskaita_web_API.Requests;

namespace _3_paskaita_web_API.Persistence
{
    public interface ICarDatabase
    {
        public IEnumerable<Car> Cars();
        public IEnumerable<Car> ByColor(string color);
        public void AddCar(CarRequest request);
        public void Update(CarRequest request, Guid id);
        public void Delete(Guid id);
    }
}
