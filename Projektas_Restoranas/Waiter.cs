namespace Projektas_Restoranas
{
    public class Waiter
    {
        public string Name { get; private set; }
        public List<Order> ListOfOrdersForThisWaiter;

        public Waiter(string name)
        {
            Name = name;
            ListOfOrdersForThisWaiter = new List<Order>();
        }    
    }
}
