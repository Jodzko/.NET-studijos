namespace Kartojimas_su_Vilmantu
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string[] strings = ["something", "anything", "Tomas", "Jonas"];

            int[] intArray = [1, 2, 5, 6, 8];

            var changedIntArray = intArray.MySelect(x => $"{x} Adding something to everything");
            foreach (var item in changedIntArray)
            {
                Console.WriteLine(item);
            }

            var stringArray = strings.MySelect(x => $"{x} Papildomas tekstas");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
            var longerThanFiveArray = strings.MyWhere(x => x.Length > 5);
            foreach (var item in longerThanFiveArray)
            {
                Console.WriteLine(item);
            }
            var biggerThanFive = intArray.MyWhere(x => x > 5);
            foreach (var item in biggerThanFive)
            {
                Console.WriteLine(item);
            }
        }


        public static IEnumerable<TResult> MySelect<T, TResult>(this IEnumerable<T> source, Func<T, TResult> doesItQualify)
        {
            foreach (var item in source)
            {
               yield return doesItQualify(item);
            }
            
        }

        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> DoesItQualify)
        {
            foreach (var item in source)
            {
                if (DoesItQualify(item))
                {
                    yield return item;
                }
            }

        }
    }
}
