namespace _10_paskaita_OOP_exception
{
    public class GFG
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            try
            {
                Console.WriteLine(arr[7]);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Element was outside of bouns of the array: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong while trying to display element: " + e.Message);
            }
        }

    }
}
