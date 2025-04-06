using _3_paskaita_web_API.Models;
using _3_paskaita_web_API.Requests;
using Microsoft.AspNetCore.Http.HttpResults;

namespace _3_paskaita_web_API.Persistence
{
    public class AccountDatabase : IAccountDatabase
    {
        private readonly AccountDbContext _context;

        public AccountDatabase(AccountDbContext context)
        {
            _context = context;

        }

        public void AddAccount(Account account)
        {
            _context.Add(account);
            _context.SaveChanges();
        }

        public Account GetAccount(string username)
        {
            return _context.Accounts.SingleOrDefault(x => x.Username == username);
        }

        //public void AddCar(CarRequest request)
        //{
        //    var car = new Car();
        //    car.Model = request.model;
        //    car.Color = request.color;
        //    _context.Cars.Add(car);
        //    _context.SaveChanges();

        //}
        //public IEnumerable<Car> ByColor(string color)
        //{
        //    return _context.Cars.Where(x => x.Color == color);
        //}
        //public IEnumerable<Car> Cars()
        //{
        //    return _context.Cars;
        //}

        //public void Update(CarRequest request, Guid id)
        //{
        //    var carInDatabase = _context.Cars.FirstOrDefault(x => x.Id == id);
        //    if (carInDatabase != null)
        //    {
        //        carInDatabase.Model = request.model;
        //        carInDatabase.Color = request.color;
        //        _context.SaveChanges();
        //    }
        //}

        //public void Delete(Guid id)
        //{
        //    var carToDelete = _context.Cars.FirstOrDefault(x => x.Id == id);
        //    if (carToDelete != null)
        //    {
        //        _context.Cars.Remove(carToDelete);
        //        _context.SaveChanges();
        //    }
        //}
    }
}
