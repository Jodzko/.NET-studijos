namespace Projektas_Restoranas
{
    public class OrderOperations
    {
        public readonly string UniqueSerialNumberFile = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Restaurant\\SerialNumberCounter.txt";


        public void StartOrder(Order order, Waiter waiter)
        {
            var lastSerialNumber = Reader.SerialNumberGetter(UniqueSerialNumberFile);
            order.UniqueSerialNumber = lastSerialNumber + 1;
            Writer.ChangeUniqueSerialNumber(UniqueSerialNumberFile, order.UniqueSerialNumber);
            var choosing = true;
            int numberOfItemsToOrder = 0;
            while (choosing)
            {
                Console.Clear();
                Console.WriteLine("How many drinks did the table order?");
                OperationConsole.ValidateInput(50, out bool menuOption, out numberOfItemsToOrder, out choosing);
                ChoosingDrinks(numberOfItemsToOrder, order, out choosing);
                break;
            }
            choosing = true;
            while (choosing)
            {
                Console.Clear();
                Console.WriteLine("How many dishes did the table order?");
                OperationConsole.ValidateInput(50, out bool menuOption, out numberOfItemsToOrder, out choosing);
                ChoosingFood(numberOfItemsToOrder,order, out choosing);
                break;

            }
            Order.ListOfActiveOrders.Add(order);
            Order.ListOfOrders.Add(order);
            waiter.ListOfOrdersForThisWaiter.Add(order);
        }

        public void ChoosingDrinks(int numberOfDrinksToOrder,Order order ,out bool choosing)
        {
            choosing = true;
            int orderedDrinks = 0;
            while (orderedDrinks < numberOfDrinksToOrder)
            {
                Console.Clear();
                string[] drinksMenu = PrintingService.ShowDrinkMenu(Order.drinksMenuPath);
                Console.WriteLine("Choose a drink: ");
                OperationConsole.ValidateInput(12, out bool menuOption, out int result, out bool breaking);
                foreach (var item in drinksMenu)
                {
                    string[] items = item.Split(' ');
                    if (int.Parse(items[0]) == result)
                    {
                        order.OrderedDrinks.Add(items[1]);
                        order.TotalPrice += decimal.Parse(items[3]);
                        order.Receipt.Add($"{items[1]}\t\t{items[3]}");
                        orderedDrinks++;
                        break;
                    }
                }
                if (orderedDrinks == numberOfDrinksToOrder)
                {
                    choosing = false;
                }
            }
        }

        public void ChoosingFood(int numberOfDishesToOrder, Order order, out bool choosing)
        {
            choosing = true;
            int orderedDishes = 0;
            while (orderedDishes < numberOfDishesToOrder)
            {
                Console.Clear();
                string[] foodMenu = PrintingService.ShowFoodMenu(Order.foodMenuPath);
                Console.WriteLine("Choose a dish: ");
                OperationConsole.ValidateInput(12, out bool menuOption, out int result, out bool breaking);
                foreach (var item in foodMenu)
                {
                    string[] items = item.Split(' ');
                    if (int.Parse(items[0]) == result)
                    {
                        order.OrderedFood.Add(items[1]);
                        order.TotalPrice += decimal.Parse(items[3]);
                        order.Receipt.Add($"{items[1]}\t\t{items[3]}");
                        orderedDishes++;
                        break;
                    }
                }
                if (orderedDishes == numberOfDishesToOrder)
                {
                    choosing = false;
                }
            }
        }

        public static void ShowOngoingOrder(int tableNumber)
        {
            Console.Clear();
            if (Order.ListOfActiveOrders.Count != 0)
            {
                foreach (var item in Order.ListOfActiveOrders)
                {
                    if (tableNumber == item.TableNumber)
                    {
                        Console.WriteLine("Current order: ");
                        foreach (var orderItem in item.Receipt)
                        {
                            Console.WriteLine(orderItem);
                        }
                        Console.WriteLine($"Total:\t\t {item.TotalPrice} Euro");
                    }
                }
            }            
            else
            {
                Console.Clear();
                Console.WriteLine("There are no ongoing orders.");
                Console.ReadLine();
            }
        }

        public static void AddToAnExistingOrder(Order order)
        {
            Console.Clear();
            if (Order.ListOfActiveOrders.Count > 0)
            {
                if (Order.ListOfActiveOrders.Contains(order))
                {
                    var choosing = true;
                    int numberOfItemsToOrder = 0;
                    while (choosing)
                    {
                        Console.WriteLine("How many drinks did the table order?");
                        OperationConsole.ValidateInput(50, out bool menuOption, out numberOfItemsToOrder, out choosing);
                        order.ChoosingDrinks(numberOfItemsToOrder, order, out choosing);
                        break;
                    }
                    choosing = true;
                    while (choosing)
                    {
                        Console.WriteLine("How many dishes did the table order?");
                        OperationConsole.ValidateInput(50, out bool menuOption, out numberOfItemsToOrder, out choosing);
                        order.ChoosingFood(numberOfItemsToOrder, order, out choosing);
                        break;

                    }
                }
                else
                {
                    Console.WriteLine("The order is not in the system.");
                }
            }
            else
            {
                Console.WriteLine("There are no current ongoing orders.");
            }
        }

        public static Order FindOrder(int tableNumber, out bool breaking)
        {
            breaking = true;
            var mostRecentOrder = new Order(OperationConsole.FindTable(tableNumber));
            var ordersOfTable = new List<Order>();
            if (Order.ListOfActiveOrders.Count != 0)
            {
                foreach (var item in Order.ListOfActiveOrders)
                {
                    if (item.TableNumber == tableNumber)
                    {
                        breaking = false;
                        return item;                        
                    }
                }
            }
            else
            {
                    breaking = true;
                    return default;
            }
            breaking = true;
            return default;
        }
        public static void ShowOrdersOfTheDay()
        {
                var orderCount = 0;
                foreach (var item in Order.ListOfOrders)
                {
                    if (!Order.ListOfActiveOrders.Contains(item))
                    {
                        Console.WriteLine($"Order number: {orderCount}");
                        Console.WriteLine($"Order staring time: {item.TimeWhenSatDown} ");
                        Console.WriteLine($"Order unique serial number: {item.UniqueSerialNumber}");
                        Console.WriteLine($"Order total price: {item.TotalPrice}");
                        Console.WriteLine($"Order finish time: {item.TimeWhenOrderFinished}");
                        Console.WriteLine($"Order tax for the restaurant: {item.TheTaxForThisTransaction}");
                    }
                }
            }
        }
    }

