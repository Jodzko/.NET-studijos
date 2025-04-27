using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Services.Interfaces
{
    public interface ICategoryService
    {
        public void AddCategoryToDatabase(string name);
        public void DeleteCategory(string name);
        public void EditCategory(string name, string newCategoryName);
    }
}
