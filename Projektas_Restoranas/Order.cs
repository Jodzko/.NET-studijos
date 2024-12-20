namespace Projektas_Restoranas
{
    public class Order : OrderOperations
    {
        public static readonly string foodMenuPath = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Restaurant\\FoodMenu.txt";
        public static readonly string drinksMenuPath = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Restaurant\\DrinkMenu.txt";
        public static readonly string SerialNumberPath = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Restaurant\\SerialNumberCounter.txt";

        public int UniqueSerialNumber { get; set; }
        public decimal TheTaxForThisTransaction;
        public int TableNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public List<string> OrderedDrinks;
        public List<string> OrderedFood;
        public decimal TotalPrice { get; set; }
        public DateTime TimeWhenSatDown { get; set; }
        public DateTime TimeWhenOrderFinished { get; set; }
        public List<string> Receipt;
        public static List<Order> ListOfOrders = new List<Order>();

        public Order(Table table)
        {
            TableNumber = table.TableNumber;
            NumberOfSeats = table.NumberOfSeats;
            TimeWhenSatDown = table.TimeWhenSatDown;
            OrderedDrinks = new List<string>();
            OrderedFood = new List<string>();
            Receipt = new List<string>();

        }       
    }
}
