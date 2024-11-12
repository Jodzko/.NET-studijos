using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektinis_Programavimas
{
    internal class Book
    {
        
        public string Name { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string PublishingCountry { get; set; }


        public Book(string name, string author, string date, string publishingCountry)
        {
            Name = name;
            Author = author;
            Date = date;
            PublishingCountry = publishingCountry;
            

        }         
    }

}
