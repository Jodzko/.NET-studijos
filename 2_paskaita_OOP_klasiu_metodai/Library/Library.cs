using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai.Library
{
    internal class Library
    {
        public List<Book> ListOfBooks { get; set; }

        public Library()
        {
            ListOfBooks = new List<Book>();
        }

      public void AddBook(string name, string author)
        {
            ListOfBooks.Add(new Book(name, author));
        }
        public void RemoveBook(string name, string author)
        {
            ListOfBooks.Remove(new Book(name, author));
        }

        public void ShowLibraryContent()
        {
            foreach (var item in ListOfBooks)
            {
                Console.WriteLine($"{item.Name} {item.Author}");
            }
        }
    }
}
