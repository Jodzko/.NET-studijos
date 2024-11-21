namespace _7_paskaita_OOP_Generics
{
    public static class Validation
    {
        public static void Validate<T>(T item)
        {
            if(item != null)
            {
                Console.WriteLine("Input is not null");
            }
            else
            {
                throw new ArgumentNullException($"Argument was null: {item}");
            }
        }

    }
}
