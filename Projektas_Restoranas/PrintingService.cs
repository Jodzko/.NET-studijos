namespace Projektas_Restoranas
{
    public static class PrintingService
    {
        public static readonly string RestaurantReceipts = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Restaurant\\Receipts.txt";

        public static string[] ShowDrinkMenu(string path)
        {
            var read = Reader.FileReader(path);
            Console.WriteLine();
            Console.WriteLine("    Drink:      Price(Euros)");
            Console.WriteLine();
            foreach (var item in read)
            {
                Console.WriteLine(item);
            }
            return read;
        }

        public static string[] ShowFoodMenu(string path)
        {
            var read = Reader.FileReader(path);
            Console.WriteLine();
            Console.WriteLine("      Dish:     Price(Euros)");
            Console.WriteLine();
            foreach (var item in read)
            {
                Console.WriteLine(item);
            }
            return read;
        }

        public static void PrintCustomerReceipt(Order order, Waiter waiter)
        {
            Console.WriteLine($"{order.TimeWhenSatDown}");
            foreach (var item in order.Receipt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Your total is: {order.TotalPrice} Euros.");
            Console.WriteLine($"You were server by {waiter.Name}");
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for dining with us, come back soon!");
        }

        public static void PrintRestaurantReceipt(Order order, Waiter waiter)
        {
            order.TimeWhenOrderFinished = DateTime.Now;
            Writer.AppendToFile(RestaurantReceipts, $"Order starting time {order.TimeWhenSatDown} \n");
            Writer.AppendToFile(RestaurantReceipts, $"Order serial number {order.UniqueSerialNumber}\n");
            Writer.AppendToFile(RestaurantReceipts, $"Order seated at table number {order.TableNumber}\n");
            Writer.AppendToFile(RestaurantReceipts, $"Name of the waiter {waiter.Name}\n");
            Writer.AppendToFile(RestaurantReceipts, $"The total price of the order {order.TotalPrice}\n");
            order.TheTaxForThisTransaction = order.TotalPrice * (decimal)0.21;
            Writer.AppendToFile(RestaurantReceipts, $"The amount of tax to pay for this transaction {order.TheTaxForThisTransaction}\n");
            Writer.AppendToFile(RestaurantReceipts, $"Order finish time {order.TimeWhenOrderFinished}\n");
            Writer.AppendToFile(RestaurantReceipts, "\n");
        }
    }
}
