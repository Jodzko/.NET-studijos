namespace _12_paskaita_OOP_delegates
{
    internal class Program
    {
        public delegate string MakeFullName(string firstName, string lasName, int age);
        private static string Name = " ";

        private delegate int ChangingNumber(int number1, int number2);
        private static int Result = 0;

        private delegate List<int> ElementByStep(List<int> list, int step);
        private static List<int> MyList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        private delegate string TypeOfElement<T>(T element);
        private static string ElementType = "";

        public delegate bool Filter (Person person);

        static void Main(string[] args)
        {
            ////var nameFirst = new MakeFullName(NameFirst);
            ////var ageFirst = new MakeFullName(AgeFirst);            
            //MakeFullName nameFirst = delegate (string firstName, string lastName, int age)
            //{
            //    return Name = firstName + lastName + age;
            //};

            //MakeFullName ageFirst = delegate (string firstName, string lastName, int age)
            //{
            //    return Name = age + firstName + lastName;
            //};

            //nameFirst("Artur", "Jodzko", 29);
            //Console.WriteLine(Name);
            //ageFirst("Artur", "Jodzko", 29);
            //Console.WriteLine(Name);


            ////var multiply = new ChangingNumber(MultiplyNumbers);          
            //ChangingNumber multiply = delegate (int number1, int number2)
            //{
            //    return Result = number1 * number2;
            //};
            //multiply(10, 25);
            //Console.WriteLine(Result);
            ////var division = new ChangingNumber(DivideNumbers);
            //ChangingNumber division = delegate (int number1, int number2)
            //{
            //    return Result = number1 / number2;
            //};
            //division(5, 5);
            //Console.WriteLine(Result);

            ////var newListByStep = new ElementByStep(ElementByStepMethod);
            //ElementByStep newListByStep = delegate (List<int> list, int step)
            //{
            //    var newList = new List<int>();
            //    for (int i = 0; i < list.Count; i += 2)
            //    {
            //        newList.Add(list[i]);
            //    }
            //    return MyList = newList;
            //};
            //newListByStep(MyList, 2);
            //foreach (var item in MyList)
            //{
            //    Console.WriteLine(item);
            //}

            ////TypeOfElement<string> typeofel1 = GetType;
            //TypeOfElement<string> typeofel1 = delegate (string item)
            //{
            //    return item.GetType().Name;
            //};
            //Console.WriteLine(typeofel1("test"));

            //var person1 = new Person("John", 29);
            //var person2 = new Person("Jack", 55);
            //var person3 = new Person("Jill", 12);
            //var person4 = new Person("Jefrey", 24);
            //var person5 = new Person("Artur", 29);
            //var person6 = new Person("Thomas", 10);
            //var person7 = new Person("Swain", 66);
            //var listOfPeople = new List<Person>
            //{
            //    person1,
            //    person2,
            //    person3,
            //    person4,
            //    person5,
            //    person6,
            //    person7
            //};



            //DisplayPeople("Children: ", listOfPeople, IsUnderEighteen);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //DisplayPeople("Adults: ", listOfPeople, IsOverEighteen);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //DisplayPeople("Seniors: ", listOfPeople, IsSenior);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

        }

        public static void DisplayPeople(string title, List<Person> people, Filter filter)
        {
            Console.WriteLine(title);

            foreach (var person in people)
            {
                Console.Write(person.Name + "  ");
                Console.Write(filter(person));
                Console.WriteLine();
            }
        }
        public static bool IsUnderEighteen(Person person)
        {
            if(person.Age < 18)
            {
                return true;
            }
            return false;
        }
        public static bool IsOverEighteen(Person person)
        {
            if(person.Age >= 18)
            {
                return true;
            }
            return false;
        }
        public static bool IsSenior(Person person)
        {
            if (person.Age >= 65)
            {
                return true;
            }
            return false;
        }

        public static string GetType<T>(T element)
        {
            return element.GetType().ToString() ;
        }

        public static List<int> ElementByStepMethod(List<int> list, int step)
        {
            var newList = new List<int>();
            for (int i = 0; i < list.Count; i+=2)
            {
                newList.Add(list[i]);
            }
            return MyList = newList;
        }
        public static int MultiplyNumbers(int number1, int number2)
        {
            return Result = number1 * number2;
        }
        public static int DivideNumbers(int number1, int number2)
        {
            return Result = number1 / number2;
        }




        public static string AgeFirst(string firstName, string lastName, int age)
        {
            return Name = age + firstName + lastName;
        }
        public static string NameFirst (string firstName, string lastName, int age)
        {
            
            return Name = firstName + lastName + age;
        }       
    }
}
