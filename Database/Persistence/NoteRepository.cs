using _web_api_project.Database.Models;
using _web_api_project.Database.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.Database.Persistence
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDbContext _context;

        public NoteRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddNoteToDatabase(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }
        
        public Note FindNoteInDatabase(Guid id)
        {
            return _context.Notes.FirstOrDefault(x => x.Id == id);
        }
        public void DeleteNote(Note note)
        {
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }

        public void UpdateNote(Note note)
        {
            _context.Update(note);
            _context.SaveChanges();
        }
        public List<Note> GetNotesByCategory(string name)
        {
            return _context.Notes.Where(x => x.Category.Name == name).ToList();
        }
    }
}
