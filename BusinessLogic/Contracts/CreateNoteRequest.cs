using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Contracts
{
    public record CreateNoteRequest(string body, string category, IFormFile? Image);
}
