using _web_api_project.BusinessLogic.Contracts;
using _web_api_project.Database.Models;
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
        public bool DeleteNote(string username, Guid noteId);
        public bool EditNote(string username, Guid noteId, string? body, string? categoryName, IFormFile? image);
        public Note GetNote(Guid id);
        public List<Note> GetByCategory(string name);

    }
}
