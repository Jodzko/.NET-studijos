using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai.Numbers
{
    internal class NumberList
    {
        public int NumberToBeAdded { get; set; }
        public List<int> AListofNumbers { get; set; } 

        public NumberList()
        {
            AListofNumbers = new List<int>();
        }

        public void AddNumberToList(int number)
        {
            
            AListofNumbers.Add(number);            
            
        }

        public void PrintNumberList()
        {
            foreach (var item in AListofNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
