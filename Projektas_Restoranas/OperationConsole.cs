namespace Projektas_Restoranas
{
    public static class OperationConsole
    {


        public static void MakeTableAvailable(Table table)
        {
            if (table.IsTableAvailable == false)
            {
                table.IsTableAvailable = true;
                table.TimeWhenFinished = DateTime.Now;
            }
            else
            {
                Console.WriteLine("This table is already available.");
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
                Console.WriteLine("This table is already unavailable.");

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
                    Console.WriteLine($"Table {item.TableNumber} is available for this group");
                }
                if (item.NumberOfSeats < amountOfPeople)
                {
                    numberOfUnavailableTables++;
                    if (numberOfUnavailableTables == Table.ListOfTables.Count)
                    {
                        Console.WriteLine("We cannot seat this group at the moment, go see the manager.");
                        break;
                    }
                }
            }
            if (numberOfUnavailableTables != Table.ListOfTables.Count) 
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
                int.TryParse(Console.ReadLine().Trim(), out result);
                if (result <= numberOfChoices && result > 0)
                {
                    breaking = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong choice, try again.");
                    continue;
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
                    Console.ReadKey();
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
                    Console.ReadKey();
                }
            }
        }

        public static Table FindTable(int tableNumber)/////////////////////////
        {
            try 
            { 
            foreach (var item in Table.ListOfTables)
            {
                if (item.TableNumber == tableNumber)
                {
                    return item;
                }
            }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return default;
        }
    }
}
