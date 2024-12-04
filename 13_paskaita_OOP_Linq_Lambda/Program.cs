namespace _13_paskaita_OOP_Linq_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> multiplyByFive = num => num * 5;
            //int result = multiplyByFive(7);


            //Func<int, int, int> add = (a, b) => a + b;
            //int result1 = add(5, 10);

            //Action<int> printExpression = num => Console.WriteLine(num);
            //Action<int> printLambdaStatement = num => 
            //{
            //    var t = "string";
            //    Console.WriteLine(t + num);
            //};

            //Predicate<int> predicate = num => num > 5;
            //bool predicateResult = predicate(10);

            //Func<string, string> selector = str => str.ToUpper();
            //string[] words = { "a", "b", "c", "name" };
            //var wordsResult = words.Select(selector);

            //var wordsResult1 = words.Select(x => x.ToUpper());


            //var t1 = words.SingleOrDefault(x => x == "name");
            //var t2 = words.FirstOrDefault(x => x == "name");
            //var t3 = words.First(x => x == "name");
            //if(t1 == null)
            //{
            //    Console.WriteLine("No records have been found");
            //}
            //var list = new List<int> { 1, 2, 3, 4, 5 };
            //Func<List<int>, List<int>> squareNumbers = num =>
            //{
            //    var newList = new List<int>();
            //    foreach (var item in num)
            //    {
            //        var newNumber = item * item;
            //        newList.Add(newNumber);
            //    }
            //    return newList;
            //};
            //var newList = squareNumbers(list);
            //var otherList = newList.Select(x => x * x);

            //var positiveAndNegativeList = new List<int> { 1, -3, 5, 2, 1, -4, -9, 8, 2, 10, 20, 25, -45, 60 };
            //var onlyPositives = positiveAndNegativeList.Where(x => x > 0);
            //var onlyPositivesSmallerThanTen = positiveAndNegativeList.Where(x => x < 10 && x > 0);

            //var byAscending = onlyPositives.Order();
            //var byDescending = onlyPositives.OrderDescending();

            //var namesList = new List<Person>
            //{
            //   new Person("James", 25),
            //   new Person("Jack", 30),
            //   new Person("Jill", 15),
            //   new Person("Frank", 19),
            //   new Person("Artur", 95),
            //   new Person("Antoine", 50),
            //   new Person("Jeffrey", 55),
            //   new Person("Mike", 65),
            //};

            //var listOnlyNames = namesList.Select(x => x.Name);
            //var listOnlyAge = namesList.Select(x => x.Age);

            //var ageByDescending = listOnlyAge.OrderDescending();
            //var nameStartsWithA = namesList.Where(x => x.Name[0] == 'A');
            //foreach (var item in nameStartsWithA)
            //{
            //    Console.WriteLine(item.Name + item.Age);
            //}
            //var overFortySorted = namesList.Where(x => x.Age > 40).OrderBy(x => x.Name);
            //foreach (var item in overFortySorted)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //var thomasPets = new List<Pets>
            //{
            //    new Pets("Kitten", 2),
            //    new Pets("Whiskers", 3),
            //    new Pets("Aido", 1)

            //};
            //var JackPets = new List<Pets>
            //{
            //    new Pets("Doggo", 8),
            //    new Pets("Aniki", 10),
            //    new Pets("Sharik", 12)

            //};
            //var ArthurPets = new List<Pets>
            //{
            //    new Pets("Fido", 0),
            //    new Pets("Journo", 6)

            //};

            //var listOfPeople = new List<Person1>
            //{
            //    new Person1("Thomas", thomasPets),
            //    new Person1("Jack", JackPets),
            //    new Person1("Arthur", ArthurPets),

            //};
            //var allPets = listOfPeople.SelectMany(p => p.ListOfPets);
            //var petsNameStartWithA = allPets.Where(x => x.NameOfPet[0] == 'A');
            //var petsNamesStartingWithAAndOverFiveYearsOld = petsNameStartWithA.Where(p => p.AgeOfPet > 5);


            //Func<string, string> returnStartingWithUpper = x => 
            //{
            //    if (x == x.ToUpper())
            //    {
            //        return x;
            //    }
            //    return default;
            //};
            //string something = "Jonathan";
            //Console.WriteLine(returnStartingWithUpper(something));

            //Console.WriteLine();

            string path = "C:\\Users\\AJodz\\OneDrive\\Desktop";
            var files = Directory.GetFiles(path);
            var listOfExtensions = "";
            foreach (var item in files)
            {
                var extension = Path.GetExtension(item);               
                listOfExtensions += extension;
            }
            var allFileExtensions = files.Select(x => Path.GetExtension(x));
            var extensions = files.Where(x => x.EndsWith(".txt"));
            var txtFileNames = files.Where(x=> x.EndsWith(".txt"))
                                    .Select(x => Path.GetFileName(x)
                                    

            );
            Console.WriteLine();

        }
       
    }
}
