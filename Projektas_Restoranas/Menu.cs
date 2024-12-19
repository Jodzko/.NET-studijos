namespace Projektas_Restoranas
{
    public static class Menu
    {


        public static void OpenMenu()
        {
            var menuOption = true;
            int result = 0;
            while (menuOption)
            {
                var choosing = true;
                while (choosing)
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1. Seat people");
                    Console.WriteLine("2. Mark a table as unoccupied");
                    Console.WriteLine("3. Enter a new order into the system");
                    Console.WriteLine("4. Add to an existing order");
                    Console.WriteLine("5. Show a list of all tables");
                    Console.WriteLine("6. Print out a receipt");
                    Console.WriteLine("7. See a table's ongoing tab");
                    Console.WriteLine("8. Make a reservation");
                    Console.WriteLine("9. Close menu");
                    OperationConsole.ValidateInput(7, out menuOption, out result, out bool breaking);
                    switch (result)
                    {
                        case 1:
                            Console.Clear();
                            breaking = true;
                            while (breaking)
                            {
                                Console.WriteLine("Enter the amount of people to be seated: ");
                                OperationConsole.ValidateInput(50, out menuOption, out result, out breaking);
                                OperationConsole.SeatPeople(result);
                                OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Which table has become available?: ");
                            OperationConsole.ValidateInput(10, out menuOption, out result, out breaking);
                            OperationConsole.MakeTableAvailable(OperationConsole.FindTable(result));
                            OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Enter the number of the table for the order: ");
                            OperationConsole.ValidateInput(10, out menuOption, out result, out breaking);                           
                            var newOrder = new Order(OperationConsole.FindTable(result));
                            newOrder.StartOrder(newOrder);
                            OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            break;
                        case 4:
                            Console.WriteLine("Enter which table's order you would like to edit: ");
                            OperationConsole.ValidateInput(10, out menuOption, out result, out breaking);
                            OrderOperations.AddToAnExistingOrder()//////////////////////////////////////////////
                            break;
                        case 5:
                            Console.Clear();
                            OperationConsole.ShowListOfTables();
                            OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            break;
                        case 6:
                            // Print out the receipt 
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Enter which table's tab you would like to see: ");
                            OperationConsole.ValidateInput(12, out menuOption, out result, out breaking);
                            Order.ShowOngoingOrder(result);
                            OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("Which table would you like to reserve?: ");
                            OperationConsole.ValidateInput(10, out menuOption, out result, out breaking);
                            OperationConsole.MakeTableUnavailable(OperationConsole.FindTable(result));
                            break;

                        case 9:
                            Console.WriteLine("Goodbye!");
                            menuOption = false;
                            break;
                        default:
                            Console.WriteLine("Incorrect input, try again");
                            Console.ReadKey();
                            break;
                    }

                }
            }
        }
    }
}
