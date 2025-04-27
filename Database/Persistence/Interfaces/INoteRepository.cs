using _web_api_project.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.Database.Persistence.Interfaces
{
    public interface INoteRepository
    {
        public void AddNoteToDatabase(Note note);
        public Note FindNoteInDatabase(Guid id);
        public void DeleteNote(Note note);
        public void UpdateNote(Note note);
        public List<Note> GetNotesByCategory(string name);


    }
}
