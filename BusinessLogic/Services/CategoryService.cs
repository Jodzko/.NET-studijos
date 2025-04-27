using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Database.Models;
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
            var category = _categoryRepository.FindCategoryInDatabase(name);
            if(category == null)
            {
                var newCategory = new Category
                {
                    Name = name
                };
                _categoryRepository.AddCategoryToDatabase(newCategory);
            }
        }
        public void DeleteCategory(string name)
        {
            var category = _categoryRepository.FindCategoryInDatabase(name);
            if(category != null)
            {
                _categoryRepository.DeleteCategory(category);
            }
        }
        public void EditCategory(string name, string newCategoryName)
        {
            var category = _categoryRepository.FindCategoryInDatabase(name);
            if (category != null)
            {
                category.Name = newCategoryName;
                _categoryRepository.UpdateCategory(category);
            }
        }
    }
}
