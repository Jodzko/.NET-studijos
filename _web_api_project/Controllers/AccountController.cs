using _web_api_project.BusinessLogic.Contracts;
using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Database.Persistence.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _web_api_project.Controllers
{    
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IJwtService _jwtService;
        private readonly IAccountService _accountService;

        public AccountController(ILogger<AccountController> logger, IAccountService accountService, IJwtService jwtService)
        {
            _logger = logger;
            _accountService = accountService;
            _jwtService = jwtService;
        }
        [HttpPost("Signup")]
        public IActionResult Signup([FromBody] SignupRequest request)
        {
            var account = _accountService.SignupNewAccount(request.Username, request.Password);
            return Ok(account);
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if(!_accountService.Login(request.Username, request.Password))
            {
                return BadRequest("Bad username or password");
            }
            var token = _jwtService.GetJwtToken(request.Username);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            _logger.LogInformation("Everything went smoothly");
            return Ok(token);
        }
    }
}
