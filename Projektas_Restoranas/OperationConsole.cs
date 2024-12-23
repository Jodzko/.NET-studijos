namespace Projektas_Restoranas
{
    public static class OperationConsole
    {


        public static void MakeTableAvailable(Table table)
        {
            if (table.IsTableAvailable == false)
            {
                if (OrderOperations.FindOrder(table.TableNumber, out bool breaking) == default)
                {
                    table.IsTableAvailable = true;
                    table.TimeWhenFinished = DateTime.Now;
                }
                else
                {
                    Console.WriteLine("The table has an ongoing order, first close the tab.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("This table is already available.");
                Console.ReadLine();
            }
        }

        public static void MakeTableUnavailable(Table table)
        {
            if (table.IsTableAvailable == true)
            {
                table.IsTableAvailable = false; ;
                table.TimeWhenSatDown = DateTime.Now;
            }
            else
            {
                Console.WriteLine("This table is occupied or unavailable.");
                Console.ReadLine();

            }
        }

        public static void ShowListOfTables()
        {
            foreach (var item in Table.ListOfTables)
            {
                Console.Write($"{item.TableNumber}\t\t");
                if (item.IsTableAvailable == true)
                {
                    Console.Write("Available");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Unavailable");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static void SeatPeople(int amountOfPeople)
        {                       
                var chosenTable = new Table(0, 0);
                var numberOfUnavailableTables = 0;
                Console.Clear();
                foreach (var item in Table.ListOfTables)
                {
                    if (item.IsTableAvailable == true && item.NumberOfSeats >= amountOfPeople)
                    {
                        Console.WriteLine($"Table {item.TableNumber} seats {item.NumberOfSeats} people and is available");
                        Console.WriteLine("\n");
                    }
                    if (item.NumberOfSeats < amountOfPeople)
                    {
                        numberOfUnavailableTables++;                       
                    }
                }
                if (numberOfUnavailableTables == Table.ListOfTables.Count)
                {
                    Console.WriteLine("This group is too big, go see the manager.");
                    Console.ReadLine();
                }
                else
                {
                    var tableChoice = true;
                    var choice = 0;
                    while (tableChoice)
                    {
                        Console.WriteLine("Which table are you taking ?");
                        if (int.TryParse(Console.ReadLine(), out int result))
                        {
                            if (choice < 0 || choice > Table.ListOfTables.Count)
                            {
                                continue;
                            }
                            else
                            {
                                choice = result;
                                tableChoice = false;
                                break;
                            }
                        }
                    }
                    foreach (var item in Table.ListOfTables)
                    {
                        if (item.TableNumber == choice)
                        {
                            chosenTable = item;
                            MakeTableUnavailable(chosenTable);
                            tableChoice = false;
                            break;
                        }
                    }
                }
        }

        public static void ValidateInput(int numberOfChoices, out bool menuOption, out int result, out bool breaking)
        {
            menuOption = true;
            breaking = true;
            result = 0;
            while (breaking)
            {
                var input = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Wrong choice, try again.");
                    continue;
                }
                else
                {
                    if (int.TryParse(input, out result))
                    {
                        if (result <= numberOfChoices && result > 0)
                        {
                            breaking = false;
                            break;
                        }
                        else if (result == 0)
                        {
                            breaking = false;
                            menuOption = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice, try again.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice, try again.");
                        break;
                    }
                }
            }
        }
        public static void GoBackToMenu(out bool menuOption, out bool choosing)
        {
            menuOption = true;
            choosing = true;
            var backToMenu = false;
            while (!backToMenu) 
            {
                Console.WriteLine("Would you like to go back to the menu screen?         (Y/N)");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input.Trim()))
                {
                    Console.WriteLine("Incorrect input, try again");
                    Console.ReadLine();
                }
                else if(input.ToLower() == "y")
                {
                    menuOption = true;
                    backToMenu = true;
                    break;
                }
                else if(input.ToLower() == "n")
                {
                    Console.WriteLine("Goodbye!");
                    menuOption = false;
                    backToMenu = false;
                    choosing = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again");
                    Console.ReadLine();
                }
            }
        }

        public static Table FindTable(int tableNumber)
        {
            if (Table.ListOfTables != null)
            {
               foreach (var item in Table.ListOfTables)
               {
                   if (item.TableNumber == tableNumber)
               {
                       return item;
               }
                   }
            }
            return default;
        }

        public static int OccupiedTablesCount()
        {
            var occupiedTableCounter = 0;
            foreach (var item in Table.ListOfTables)
            {
                if (item.IsTableAvailable == false)
                {
                    occupiedTableCounter++;
                }
            }
             return occupiedTableCounter;          
        }
    }
    }

