namespace Projektas_Restoranas
{
    public static class DrinksMenu 
    {
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
    }
}
