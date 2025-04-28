using _web_api_project.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.Database.Persistence.Interfaces
{
    public interface ICategoryRepository
    {
        public void AddCategoryToDatabase(Category category);
        public Category FindCategoryInDatabase(string name);
        public void DeleteCategory(Category category);
        public void UpdateCategory(Category category);
        public Category FindAccountById(Guid id);

    }
}
