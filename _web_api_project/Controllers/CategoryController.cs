using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _web_api_project.Api.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<AccountController> _logger;

        public CategoryController(ICategoryService categoryService, ILogger<AccountController> logger)
        {
            _categoryService = categoryService;
            _logger = logger;
        }


    }
}
