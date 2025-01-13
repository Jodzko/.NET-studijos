using Microsoft.EntityFrameworkCore;

namespace Bandymas_SQL_C_
{
    public class TournamentTable
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public List<Person> Persons { get; set; }

        public TournamentTable( string category)
        {
            Id = Guid.NewGuid();
            Category = category;
            Persons = new List<Person>();
        }
    }
}
