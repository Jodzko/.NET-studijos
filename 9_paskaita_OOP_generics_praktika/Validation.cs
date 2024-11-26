namespace _9_paskaita_OOP_generics_praktika
{
    public class Validation
    {
        
        public static void Validate<T>(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Argument was null");
            }          
        }

    }
}

