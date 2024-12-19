namespace Projektas_Restoranas
{
    public static class FoodMenu
    {
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
    }
}
