namespace _3_paskaita_web_API
{
    public interface ICarDatabase
    {
        public List<Car> Cars();
        public List<Car> ByColor(string color);
        void AddCar(Car car);
        void Update(Guid id, Car car);
        void Delete(Guid id);
    }
}
