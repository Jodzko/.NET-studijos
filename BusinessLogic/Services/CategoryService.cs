using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Database.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategoryToDatabase(string name)
        {
            if(_categoryRepository.FindCategoryInDatabase(name) == null)
            {

            }
        }
    }
}
