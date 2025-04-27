using _web_api_project.BusinessLogic.Contracts;
using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Controllers;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory([FromForm] CategoryRequest request)
        {
            _categoryService.AddCategoryToDatabase(request.name);
            return Ok();
        }
        [Authorize]
        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory([FromQuery] CategoryRequest categoryName,[FromBody] CategoryRequest newCategory)
        {
            _categoryService.EditCategory(categoryName.name, newCategory.name);
            return Ok();
        }
        [Authorize]
        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory([FromForm] string name)
        {
            _categoryService.DeleteCategory(name);
            return Ok();
        }
    }
}
