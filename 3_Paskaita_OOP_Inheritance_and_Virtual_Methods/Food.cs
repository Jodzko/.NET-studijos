namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Food : Product
    {
        public int ExpirationTime { get; set; }

        public Food(string name, int price, int expiration) : base(name, price)
        {
            ExpirationTime = expiration;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Price}  {ExpirationTime}");
        }
    }
}
