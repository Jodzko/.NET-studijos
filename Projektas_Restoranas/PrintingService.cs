using System.Text;

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

        public static string PrintCustomerReceipt(Order order, Waiter waiter)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t Your receipt: ");
            var builder = new StringBuilder();
            builder.AppendLine($"{order.TimeWhenSatDown}");
            foreach (var item in order.Receipt)
            {
                builder.AppendLine(item);
            }
            builder.AppendLine($"Your total is: {order.TotalPrice} Euros.");
            builder.AppendLine($"You were server by {waiter.Name}");
            builder.AppendLine("\n");
            builder.AppendLine("Thank you for dining with us, come back soon!");
            Console.WriteLine(builder.ToString()); 
            return builder.ToString();
        }

        public static string PrintRestaurantReceipt(Order order, Waiter waiter)
        {
            var builder = new StringBuilder();
            order.TheTaxForThisTransaction = order.TotalPrice * (decimal)0.21;
            order.TimeWhenOrderFinished = DateTime.Now;
            builder.AppendLine($" \t\t\t Restaurant receipt:");
            builder.AppendLine($"Order starting time {order.TimeWhenSatDown}");
            builder.AppendLine($"Order serial number {order.UniqueSerialNumber}");
            builder.AppendLine($"Order seated at table number {order.TableNumber}");
            builder.AppendLine($"Name of the waiter {waiter.Name}");
            builder.AppendLine($"The total price of the order {order.TotalPrice}");
            builder.AppendLine($"The amount of tax to pay for this transaction {order.TheTaxForThisTransaction}");
            builder.AppendLine($"Order finish time {order.TimeWhenOrderFinished}");
            builder.AppendLine("");
            Writer.AppendToFile(RestaurantReceipts, builder.ToString());
            return builder.ToString();
        }
    }
}
