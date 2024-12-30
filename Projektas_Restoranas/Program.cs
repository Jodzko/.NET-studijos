namespace Projektas_Restoranas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var foodMenuPath = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Restaurant\\FoodMenu.txt";
            var drinksMenuPath = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Restaurant\\DrinkMenu.txt";
            var SerialNumberPath = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Restaurant\\SerialNumberCounter.txt";

            var waiter = new Waiter("John");
            Table.ListOfTables.Add(new Table(1, 4));      
            Table.ListOfTables.Add(new Table(2, 2));      
            Table.ListOfTables.Add(new Table(3, 6));      
            Table.ListOfTables.Add(new Table(4, 10));      
            Table.ListOfTables.Add(new Table(5, 20));
            Table.ListOfTables.Add(new Table(6, 2));
            Table.ListOfTables.Add(new Table(7, 4));
            Table.ListOfTables.Add(new Table(8, 6));
            Table.ListOfTables.Add(new Table(9, 4));
            Table.ListOfTables.Add(new Table(10, 4));
            Menu.OpenMenu(waiter);

            




        }
        

    }
}
