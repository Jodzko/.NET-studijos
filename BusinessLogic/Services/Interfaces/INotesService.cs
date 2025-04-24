using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Services.Interfaces
{
    public interface INotesService
    {
        public void CreateNote(string username, string body, string categoryName, IFormFile? image);

    }
}
