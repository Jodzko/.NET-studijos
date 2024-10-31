using System.ComponentModel;

namespace _16_Paskaita_Dictionaries
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cities = new Dictionary<string, int>(); //Tuscio deklaravimas(gale turi buti()  )

            var citiesWithValues = new Dictionary<string, int>
            {
                { "Vilnius", 9 },
                { "Kaunas" , 8 },
                { "Klaipeda", 10 }
            };
            var playerPoints = new Dictionary<string, List<int>>();
            var playerPointsWithValues = new Dictionary<string, List<int>>
            {
                {"Tomas", new List<int> {7, 8, 9} }
            };

            foreach (var cityKeyValuePair in citiesWithValues)
            {
                //Console.WriteLine(cityKeyValuePair);
                //Console.WriteLine(cityKeyValuePair.Key);
                //Console.WriteLine(cityKeyValuePair.Value);
            }
            var isValue = playerPoints.TryGetValue("Tomas", out var points);
           
            if (!isValue)
            {
                playerPoints.Add("Tomas", new List<int> { 9 });
            }
            //Methods.InformationRetainment();
            //Console.WriteLine("Enter a country: ");
            //string country = Console.ReadLine();
            //Methods.CountryCapital(country);
            var fruitsAndCount = new Dictionary<string, int>
            {
                {"Pear", 19 },
                {"Apple", 27 },
                {"Guava", 42 }
            };
            Methods.FruitsAndCount(fruitsAndCount);
            Console.WriteLine("Enter the fruit you wish to add: ");
            string addingFruit = Console.ReadLine();
            Console.WriteLine("Enter the quantity of said fruit: ");
            int quantity = int.Parse(Console.ReadLine());
            var updatedFruit = Methods.UpdateFruits(fruitsAndCount, addingFruit, quantity);
            foreach (var item in updatedFruit)
            {
                Console.WriteLine(item);
            }
            


        }
        public static class Methods
        {
            public static Dictionary<string, int> InformationRetainment()
            {
                var information = new Dictionary<string, int>
                {
                    {"Tomas", 19 },
                    {"Jonas", 27 },
                    {"Antanas", 42 }
                };
                foreach (var nameAgePair in information)
                {
                    Console.WriteLine(nameAgePair);
                }
                return information;
            }
            public static Dictionary<string, string> CountriesAndCapitals()
            {
                var countriesAndCapitals = new Dictionary<string, string>
                {
                    {"Lithuania", "Vilnius" },
                    {"Latvia", "Ryga" },
                    {"Netherlands", "Amsterdam" },
                    {"Estonia", "Talinn" }
                };
                return countriesAndCapitals;
            }
            public static string CountryCapital (string country)
            {
                string capital = "";
                var database = Methods.CountriesAndCapitals();
                foreach (var countries in database)
                {
                    if (countries.Key == country)
                    {
                        Console.WriteLine($"That countrys capital is :   {countries.Value} ");
                        capital = countries.Value;
                    }                   
                }
                return capital;
            }
            public static void FruitsAndCount (Dictionary<string, int> fruits)
            {
                foreach (var item in fruits)
                {
                    Console.WriteLine(item);
                }
            }
            public static Dictionary<string, int> UpdateFruits(Dictionary<string, int> fruits, string addingFruit, int quantity)
            {
                
                if (fruits.ContainsKey(addingFruit))
                {
                    var newFruits = new Dictionary<string, int>();
                    foreach (var item in fruits)
                    {                       
                        if(item.Key == addingFruit)
                        {
                            int x = item.Value;
                            newFruits.Add(item.Key, x + quantity);
                            continue;
                        }
                        newFruits.Add(item.Key, item.Value);
                    }
                    fruits = newFruits;
                }
                   
                
                else
                {
                    fruits.Add(addingFruit, quantity);
                }
                return fruits;
            }
        }
    }
}
