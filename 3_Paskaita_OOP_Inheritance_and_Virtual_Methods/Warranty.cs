namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Warranty : Product
    {
        public int WarrantyLeft { get; set; }

        public Warranty(int warrantyLeft, string name, int price) : base(name, price)
        {
            WarrantyLeft = warrantyLeft;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Price} {WarrantyLeft}");
        }
    }
}
