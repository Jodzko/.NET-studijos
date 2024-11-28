using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace _11_paskaita_OOP_extensions
{
    public static class Extensions
    {
        public static int Number { get; set; }

        //Static method
        public static void Print()
        {
            Console.WriteLine("Hello from Print");
        }

        //Extension mehod
        public static int WordCount(this string input)
        {
            return input.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool IsNumberPositive(this int input)
        {
            
            if(input > 0)
            {
                Console.WriteLine("The number is positive.");
                return true;
            }
            Console.WriteLine("The number was negative.");
            return false;
        }

        public static bool IsNumberEven(this int input)
        {
            if(input % 2 == 0)
            {
                Console.WriteLine("The number was even");
                return true;
            }
            Console.WriteLine("The number was odd");
            return false;
        }

        public static bool IsEnteredNumberHigherThanARandomNumber(this int input)
        {
            Random random = new Random();
            int aRandomNumber = random.Next();
            if(input > aRandomNumber)
            {
                Console.WriteLine("Your number is higher than " + aRandomNumber);
                return true;
            }
            Console.WriteLine("Your number was lower than " + aRandomNumber);
            return false;
        }

        public static bool DoesStringContainEmptySpaces(this string input)
        {
            if(input.Contains(' '))
            {
                Console.WriteLine("The string contains spaces.");
                return true;
            }
            Console.WriteLine("The string does not contain spaces");
            return false;
        }

        public static string MakeEmail(this string fullName, int yearOfBirth, string domain)
        {
            var email = fullName + yearOfBirth + domain;
            Console.WriteLine(email);
            return email;
        }

        public static T FindAndReturnIfEquals<T>(this T item, List<T> myList)
        {
            if (item != null && myList.Contains(item))
            {                
                    Console.WriteLine(item);
                    return item;               
            }
                    Console.WriteLine("Item was not found");
                    return default;               
            
        }
        
        public static List<T> EveryOtherWord<T>(this List<T> myList)
        {
            var newList = new List<T>();
            for (int i = 0; i < myList.Count; i+=2)
            {
                newList.Add(myList[i]);
            }
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            return newList;
        }

        //public static Span<string> EveryOtherLine(this string path)
        //{
        //    var fileContent = File.ReadAllLines(path);
        //    Span<string> span = fileContent.AsSpan();
        //    Span<string> slice = default;
        //    for (int i = 0; i <= span.Length; i+=2)
        //    {
        //        Span<string> slice1 = span.Slice(0, i);               
        //        if(i == span.Length)
        //        {
        //            slice = slice1;
        //        }
        //    }
        //    foreach (var item in slice)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    return slice;
        //}
    public static StringBuilder EveryOtherLine(this string path)
        {
            var newString = new StringBuilder();
            var fileContent = File.ReadAllLines(path);
            for (int i = 0; i < fileContent.Length; i++)
            {
                newString.Append(fileContent[i] + " ");
            }
            return newString;
        }
    }
}
