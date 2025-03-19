using Microsoft.AspNetCore.Http.HttpResults;

namespace _3_paskaita_web_API
{
    public class CarDatabase : ICarDatabase
    {
        public List<Car> _cars = [];

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }
        public List<Car> ByColor(string color)
        {
            return _cars.Where(x => x.Color == color).ToList();
        }
        public List<Car> Cars()
        {
            return _cars;
        }

        public void Update(Guid id, Car car)
        {
            var carInDatabase = _cars.FirstOrDefault(x => x.Id == id);
            if(carInDatabase != null)
            {
                carInDatabase.Model = car.Model;
                carInDatabase.Color = car.Color;
            }
        }

        public void Delete(Guid id)
        {
            var carToDelete = _cars.FirstOrDefault(x => x.Id == id);
            if(carToDelete != null)
            {
                _cars.Remove(carToDelete);
            }
        }
    }
}
