using System.Threading.Channels;

namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product()
        {

        }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        
        
    }
}
