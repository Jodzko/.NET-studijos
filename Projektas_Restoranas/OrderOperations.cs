namespace Projektas_Restoranas
{
    public class OrderOperations
    {
        public void StartOrder(Order order)
        {
            var choosing = true;
            int numberOfItemsToOrder = 0;
            while (choosing)
            {
                Console.WriteLine("How many drinks did the table order?");
                OperationConsole.ValidateInput(50, out bool menuOption, out numberOfItemsToOrder, out choosing);
                ChoosingDrinks(numberOfItemsToOrder, order, out choosing);
                break;
            }
            choosing = true;
            while (choosing)
            {
                Console.WriteLine("How many dishes did the table order?");
                OperationConsole.ValidateInput(50, out bool menuOption, out numberOfItemsToOrder, out choosing);
                ChoosingFood(numberOfItemsToOrder,order, out choosing);
                break;

            }
            Order.ListOfOrders.Add(order);
        }

        public void ChoosingDrinks(int numberOfDrinksToOrder,Order order ,out bool choosing)
        {
            choosing = true;
            int orderedDrinks = 0;
            while (orderedDrinks < numberOfDrinksToOrder)
            {
                Console.Clear();
                string[] drinksMenu = DrinksMenu.ShowDrinkMenu(Order.drinksMenuPath);
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
                string[] foodMenu = FoodMenu.ShowFoodMenu(Order.foodMenuPath);
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
            Order mostRecentOrder = new Order(OperationConsole.FindTable(1));
            var listOfOrdersOnTheTable = new List<Order>();
            var orderCount = 0;
            if (Order.ListOfOrders != null)
            {
                foreach (var item in Order.ListOfOrders)
                {
                    if (tableNumber == item.TableNumber)
                    {
                        orderCount++;
                        listOfOrdersOnTheTable.Add(item);
                    }
                }
                if (orderCount > 0)
                {
                    for (int i = 0; i < listOfOrdersOnTheTable.Count - 1; i++)
                    {
                        if (listOfOrdersOnTheTable[i].UniqueSerialNumber > listOfOrdersOnTheTable[i + 1].UniqueSerialNumber)
                        {
                            mostRecentOrder = listOfOrdersOnTheTable[i];
                        }
                        else
                        {
                            mostRecentOrder = listOfOrdersOnTheTable[i + 1];
                        }
                    }

                    Console.WriteLine("Current order: ");
                    foreach (var item in mostRecentOrder.Receipt)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine($"Total:\t\t {mostRecentOrder.TotalPrice} Euro");
                }
                else
                {
                    Console.WriteLine("This table doesnt have any orders.");
                }
            }
            else
            {
                Console.WriteLine("There are no ongoing orders.");
            }
        }

        public static void AddToAnExistingOrder(Order order)
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

        public Order FindOrder(int tableNumber)////////////////////////////
        {
            if (Order.ListOfOrders != null)
            {
                foreach (var item in Order.ListOfOrders)
                {
                    if (item.TableNumber == tableNumber)
                    {
                        return item;
                    }
                }
            }
            else
            {
                Console.WriteLine("Couldn't find that order");
                return default;
            }
            return default;
        }
    }
}
