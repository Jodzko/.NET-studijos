namespace Projektas_Restoranas
{
    public static class Menu
    {
        public static void OpenMenu(Waiter waiter)
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
                    OperationConsole.ValidateInput(9, out menuOption, out result, out bool breaking);
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
                            OperationConsole.ValidateInput(Table.ListOfTables.Count, out menuOption, out result, out breaking);
                            OperationConsole.MakeTableAvailable(OperationConsole.FindTable(result));
                            OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Enter the number of the table for the order: ");
                            OperationConsole.ValidateInput(Table.ListOfTables.Count, out menuOption, out result, out breaking);
                            if (OperationConsole.FindTable(result).IsTableAvailable == true)
                            {
                                Console.WriteLine("You must first seat people.");
                                Console.ReadKey();
                            }
                            else
                            {
                                var newOrder = new Order(OperationConsole.FindTable(result));
                                newOrder.StartOrder(newOrder, waiter);
                                OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            }
                            break;
                        case 4:
                            if (Order.ListOfOrders.Count != 0)
                            {
                                Console.WriteLine("Enter which table's order you would like to edit: ");
                                OperationConsole.ValidateInput(Table.ListOfTables.Count, out menuOption, out result, out breaking);
                                OrderOperations.AddToAnExistingOrder(OrderOperations.FindOrder(result, out breaking));
                                OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            }
                            else
                            {
                                Console.WriteLine("There are no ongoing orders.");
                                Console.ReadKey();
                            }
                            break;
                        case 5:
                            Console.Clear();
                            OperationConsole.ShowListOfTables();
                            OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            break;
                        case 6:
                            breaking = true;
                            var order = new Order(OperationConsole.FindTable(1));
                            while (breaking)
                            {
                                Console.WriteLine("Which table's receipt would you like to print?");
                                OperationConsole.ValidateInput(Table.ListOfTables.Count, out menuOption, out result, out breaking);
                                if(result == 0)
                                {
                                    Console.WriteLine("Incorrect input, try again.");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    order = OrderOperations.FindOrder(result, out breaking);
                                    break;
                                }
                            }
                            while (!breaking) 
                            { 
                            Console.WriteLine("Would the customer like a receipt?            (Y/N)");
                            string receipt = Console.ReadLine();
                            if (string.IsNullOrEmpty(receipt.Trim()))
                            {
                                    Console.WriteLine("Incorrect input, try again.");
                            }
                            else if(receipt.ToLower() == "n")
                                {
                                    PrintingService.PrintRestaurantReceipt(order, waiter);
                                    breaking = true;
                                }
                            else if(receipt.ToLower() == "y")
                                {
                                    PrintingService.PrintCustomerReceipt(order, waiter);
                                    PrintingService.PrintRestaurantReceipt(order, waiter);
                                    breaking = true;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect input, try again. ");
                                    break;
                                }
                            }
                            while (breaking)
                            {
                                Console.WriteLine("Would the customer like a digital receipt? ");
                                string receipt = Console.ReadLine();
                                if (string.IsNullOrEmpty(receipt.Trim()))
                                {
                                    Console.WriteLine("Incorrect input, try again.");
                                }
                                else if (receipt.ToLower() == "n")
                                {
                                    breaking = false;
                                    break;
                                }
                                else if (receipt.ToLower() == "y")
                                {
                                    MailSendingService.SendingEmail(order);
                                    breaking = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect input, try again. ");
                                    break;
                                }
                            }

                            OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            break;
                        case 7:
                            Console.Clear();
                            if (Order.ListOfOrders.Count != 0)
                            {
                                Console.WriteLine("Enter which table's tab you would like to see: ");
                                OperationConsole.ValidateInput(12, out menuOption, out result, out breaking);
                                Order.ShowOngoingOrder(result);
                                OperationConsole.GoBackToMenu(out menuOption, out choosing);
                            }
                            else
                            {
                                Console.WriteLine("There are no ongoing orders.");
                                Console.ReadKey();
                            }
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("Which table would you like to reserve?: ");
                            OperationConsole.ValidateInput(Table.ListOfTables.Count, out menuOption, out result, out breaking);
                            if(OperationConsole.FindTable(result).IsTableAvailable == false)
                            {
                                Console.WriteLine("You must first make the table available, wait for the customers to leave, then reserve this table.");
                            }
                            else
                            {
                                OperationConsole.MakeTableUnavailable(OperationConsole.FindTable(result));

                            }
                            break;

                        case 9:
                            Console.WriteLine("Goodbye!");
                            menuOption = false;
                            choosing = false;
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
