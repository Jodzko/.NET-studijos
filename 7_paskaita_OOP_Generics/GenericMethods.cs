using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_paskaita_OOP_Generics
{
    internal class GenericMethods
    {        

        public void ShowItem<T>(T item)
        {
            Console.WriteLine(item);
        }

        public string GetTypeName<T>(T item)
        {
            if (item != null)
            {
                return item.GetType().Name;
            }
            else
            {
                return string.Empty;
            }
        }
        public void ShowValues<T1, T2>(T1 item1, T2 item2)
        {
            if(item1 != null)
            {
                Console.WriteLine(item1.GetType().Name);
            }
            else
            {
                Console.WriteLine($"{item1} was null");
            }
            if(item2 != null)
            {
                Console.WriteLine(item2.GetType().Name);
            }
            else
            {
                Console.WriteLine($"{item2} was null");
            }
        }
    }
}
