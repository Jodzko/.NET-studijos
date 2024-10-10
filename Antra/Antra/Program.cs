using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Antra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstLine = "vienas";
            string secondLine = "du";
            firstLine += secondLine;

            string city = "Vilnius";
            int wordLength = "Vilnius".Length;
            int wordLength2 = city.Length;
            Console.WriteLine(wordLength);
            Console.WriteLine(wordLength2);
            string myInput2 = "CodeAcademy";
            //char yra vienas simbolis
            //word[index] grazina simboli esanti index vietoje
            char myChar = myInput2[0];
            Console.WriteLine(myChar);
            int lastIndex = myInput2.Length - 1;
            char lastChar = myInput2[lastIndex];
            Console.WriteLine(lastChar);
            //char wrongChar = myInput2[myInput2.Length];
            Console.WriteLine("Iveskite savo miesta: ");
            string miestas = Convert.ToString(Console.ReadLine());
            int paskutinis = miestas.Length - 1;
            char paskutinis1 = miestas[paskutinis];
            Console.WriteLine(paskutinis1);
            string word1 = "mama";
            string word2 = word1.Replace('m', 'p');
            Console.WriteLine(word1 + " ir " + word2);

            Console.WriteLine("Iveskite zodi");
            string ivadas = Console.ReadLine();
            char trecia = ivadas[2];
            Console.WriteLine("zodzio ilgis:");
            Console.WriteLine(ivadas.Length);
            Console.WriteLine("trecia raide yra: ");
            Console.WriteLine(trecia);
            //substring metodas grazina nauja eilute kopijuojant nurodytu simboliu seka
            string s = "Mano Vardas Artur";
            string vardas = s.Substring(12);
            Console.WriteLine(vardas);
            
            string mano = s.Substring(0, 4);
            Console.WriteLine(mano);
            // ctrl+d duplikuoja eilute



            //IndexOf 
            string myWord5 = "CodeAcademy";
            int index1 = myWord5.IndexOf('c');
            int index2 = myWord5.IndexOf("Code");
            Console.WriteLine(index1);

            //Trim nutrina priekyje ir gale esancius tuscius tarpus
            string opa = "     Mano vardas Artur     ";
            Console.WriteLine("Before Trim");
            Console.WriteLine(opa);
            Console.WriteLine("After Trim");
            Console.WriteLine(opa.Trim());

            //Eiluciu apjungimas - Concat 
            string o = "api", g = "bend", c = "rinimas";
            string result = "";
            string result2 = "";
            result += g;
            result += c;

            result2 = string.Concat(o, g, c);
            //string g = "bend";
            //string c = "rinimas";


            //ToString()
            int number = 987;
            string numberString = number.ToString();
            string numberString2 = Convert.ToString(number);
            int convertedNumber = Convert.ToInt32(numberString);
            string charString = numberString[0].ToString();
            string upperCase = numberString.ToUpper();
            string lowerCase = numberString.ToLower();
           


            //If ir else funkcija
            int k = 6;
            int l = 7;
            Console.WriteLine(firstLine);
            Console.WriteLine("");
            
            if (k == l)
            {
                Console.WriteLine("Jie vienodi");
            }
          
            else
            {
                Console.WriteLine("Jie nevienodi");
                Console.WriteLine("");
            };
            Console.WriteLine("Iveskite skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 5)
                Console.WriteLine("Jusu skaicius 5");
            else if (n > 5)
                Console.WriteLine("Jusu skaicius daugiau uz 5");
            else Console.WriteLine("Jusu skaicius maziau uz 5");

        }
    }
    }

