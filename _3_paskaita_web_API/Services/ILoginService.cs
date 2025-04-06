//using _11_paskaita_JWT.Models;
using _3_paskaita_web_API.Models;

namespace _11_paskaita_JWT.Services
{
    public interface ILoginService
    {
        bool SignupNewAccount(string username, string password);
        bool Login(string username, string password, out string role);
        Account CreateAccount(string username, string password);
    }
}
