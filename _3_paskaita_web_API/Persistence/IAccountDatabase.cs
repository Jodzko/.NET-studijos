using _3_paskaita_web_API.Models;
using _3_paskaita_web_API.Requests;

namespace _3_paskaita_web_API.Persistence
{
    public interface IAccountDatabase
    {
        //public IEnumerable<Account> Accounts();
        //public IEnumerable<Account> ByColor(string color);
        public void AddAccount(Account account);
        public Account GetAccount(string username);
        //public void Update(CarRequest request, Guid id);
        //public void Delete(Guid id);
    }
}
