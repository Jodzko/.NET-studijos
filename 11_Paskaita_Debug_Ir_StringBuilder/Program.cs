using System.Security.Cryptography;
using System.Text;

namespace _11_Paskaita_Debug_Ir_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 5;
            //int c = 8;

            //int max = a;
            //if (b > max)
            //    max = b;
            //if (c > max)
            //    max = c;
            //Console.WriteLine("The maximum value is : " + max);
            //string firstName = "John";
            //string lastName = "Doe";
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine("Full Name: " + fullName); 
            //int counter = 0;
            //while(counter <= 10)
            //{
            //    Console.WriteLine("Count: " + counter);
            //    counter++;
            //}
            //int i = 1; 
            //while (i > 0 && i <=5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //string name1 = "John";
            //string name2 = "john";
            //if (name1.ToLower().Equals(name2.ToLower()))
            //{
            //    Console.WriteLine("Names are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("Names are different.");
            //}
            //Console.WriteLine("Ivesta fraze: " + fraze);
            //string apverstaFraze = new string(stringBuilder.ToString().Reverse().ToArray());
            //stringBuilder.Append(apverstaFraze);
            //Console.WriteLine("Apversta fraze: " + apverstaFraze);

            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Iveskite fraze: ");
            string fraze = Console.ReadLine();
            string raides = new string (fraze.ToCharArray());
            for (int i = 0;  i < raides.Length; i++)
            {
                char vienaRaide = raides[i];
                
                if (stringBuilder.ToString().Contains(raides[i]))
                {
                    continue;
                    //Console.WriteLine("sita raide yra: " + raides[i].ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(vienaRaide);
                    
                }
            }
            Console.WriteLine(stringBuilder);



        }

        public static string GetFullName(string firstName, string LastName)
        {
            Console.WriteLine("Registruotas naudotojas: " + firstName + " " + LastName);
            return firstName.Trim() + " " + LastName.Trim();
        }
        public static void PrintError(string errorText)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(errorText);
            Console.ResetColor();
        }
      
        
    }
}
