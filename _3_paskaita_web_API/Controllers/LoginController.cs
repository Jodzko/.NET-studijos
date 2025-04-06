using _11_paskaita_JWT.Services;
using _3_paskaita_web_API.Contracts;
using _3_paskaita_web_API.Models;
using _3_paskaita_web_API.Persistence;
using _3_paskaita_web_API.Requests;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_paskaita_web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAccountDatabase _accountDatabase;
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService _loginService;
        private readonly IJwtService _jwtService;
        private readonly AccountDbContext _context;

        public LoginController(IAccountDatabase accountDatabase, ILogger<LoginController> logger, IJwtService jwt, AccountDbContext context, ILoginService login)
        {
            _logger = logger;
            _accountDatabase = accountDatabase;
            _jwtService = jwt;
            _context = context;
            _loginService = login;
        }

        [HttpPost("signup")]
        public IActionResult Signup([FromBody] SignupRequest request)
        {
            var account = _loginService.SignupNewAccount(request.Username, request.Password);
                return Ok(account);


        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Contracts.LoginRequest request)
        {
            if(!_loginService.Login(request.Username, request.Password, out string role))
            {
                return BadRequest("Bad username or password");
            }
            var token = _jwtService.GetJwtToken(request.Username, role);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            _logger.LogInformation("Everything went smoothly");
            return Ok(token);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "User")]
        [HttpGet("ShowUsers")]
        public IActionResult GetUsers()
        {
            return Ok(_context.Accounts.ToList());
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpDelete]
        public IActionResult Delete([FromBody] string username)
        {
            var accountToDelete = _accountDatabase.GetAccount(username);
            if(accountToDelete != null)
            {
            _context.Accounts.Remove(accountToDelete);
                _context.SaveChanges();
                _logger.LogInformation("Everything went smoothly");
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPut]
        public IActionResult MakeAnAdmin([FromBody]string username)
        {
            var accountToPromote = _accountDatabase.GetAccount(username);
            if(accountToPromote != null)
            {
            accountToPromote.Role = "Admin";
            _logger.LogInformation("Everything went smoothly");
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        //[HttpPost]
        //public ActionResult AddCar([FromBody] CarRequest request)
        //{
        //    _carDatabase.AddCar(request);
        //    return Ok();
        //}

        //[HttpGet]
        //public ActionResult GetCars()
        //{
        //    _logger.LogWarning("Something went wrong");
        //    return Ok(_carDatabase.Cars());
        //}

        //[HttpGet("Color")]
        //public ActionResult ByColor([FromQuery] string color)
        //{
        //    return Ok(_carDatabase.ByColor(color));
        //}
        //[HttpPut]
        //public ActionResult Update([FromBody] CarRequest request, [FromQuery] Guid id)
        //{
        //    _carDatabase.Update(request, id);
        //    return Ok();
        //}
        //[HttpDelete]
        //public ActionResult Delete(Guid id)
        //{
        //    _carDatabase.Delete(id);
        //    return Ok();
        //}
    }
}
