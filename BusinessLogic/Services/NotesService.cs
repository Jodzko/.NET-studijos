using _web_api_project.BusinessLogic.Contracts;
using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Database.Models;
using _web_api_project.Database.Persistence.Interfaces;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Services
{
    public class NotesService : INotesService
    {
        private readonly INoteRepository _noteRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ICategoryRepository _categoryRepository;

        public NotesService(INoteRepository noteRepository, IAccountRepository accountRepository, ICategoryRepository categoryRepository)
        {
            _noteRepository = noteRepository;
            _accountRepository = accountRepository;
            _categoryRepository = categoryRepository;
        }

        public void CreateNote(string username, string body, string categoryName, IFormFile? image)
        {
            var account = _accountRepository.FindAccountInDatabase(username);
            var category = _categoryRepository.FindCategoryInDatabase(categoryName);
            var note = new Note
            {
                Category = category,
                Body = body,
                Account = account                
            };
            byte[]? imageData = null;
            if (image != null && image.Length > 0)
            {
                using var memoryStream = new MemoryStream();
                image.CopyToAsync(memoryStream);
                imageData = memoryStream.ToArray();
                note.ImageData = imageData;
            }
            category.Notes.Add(note);
            _noteRepository.AddNoteToDatabase(note);
        }
        public bool EditNote(string username, Guid noteId, string? body, string? categoryName, IFormFile? image)
        {
            var noteInDatabase = _noteRepository.FindNoteInDatabase(noteId);
            if (noteInDatabase.Account.Username == username)
            {
                if(body != null)
                {
                    noteInDatabase.Body = body;
                }
                if(categoryName != null)
                {
                    noteInDatabase.Category = _categoryRepository.FindCategoryInDatabase(categoryName);
                }
                if(image != null && image.Length > 0)
                {
                    byte[]? imageData = null;
                    using var memoryStream = new MemoryStream();
                    image.CopyToAsync(memoryStream);
                    imageData = memoryStream.ToArray();
                    noteInDatabase.ImageData = imageData;
                }
                _noteRepository.UpdateNote(noteInDatabase);
                return true;
            }
            return false;
        }

        public bool DeleteNote(string username, Guid id)
        {
            var noteInDatabase = _noteRepository.FindNoteInDatabase(id);
            if(noteInDatabase.Account.Username == username)
            {
                _noteRepository.DeleteNote(noteInDatabase);
                return true;
            }
            return false;
        }
        public Note GetNote(Guid id)
        {
            return _noteRepository.FindNoteInDatabase(id);
        }
        public List<Note> GetByCategory(string name)
        {
            return _noteRepository.GetNotesByCategory(name);
        }
    }
}
