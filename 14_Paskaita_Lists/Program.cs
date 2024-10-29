using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _14_Paskaita_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pavyzdziai
            //List<int> numbers = new List<int>();

            //List<int> numbersWithValues = new List<int> { 99, 101, 642 };

            //var myVarNumbers = new List<int>();
            // Uzduotys
            //List <string> elementai = new List <string> { "Jonas", "Petras", "Vladas" };
            //Methods.ListoElementuIlgis(elementai);
            //List<int> sarasas = new List<int>();
            //List<int> uzpildytasSarasas = Methods.SarasoUzpildymas(sarasas);
            //double vidurkis = Methods.VidurkioSkaiciavimas(uzpildytasSarasas);
            //Console.WriteLine(vidurkis);
            //var sarasas1 = new List <int>{ 1, 2, 15, 45, 85, 65, 2, 4 };
            //var atrusiuotasSarasas = Methods.DidesniuSkaiciuGavimas(sarasas1);
            //foreach (var item in atrusiuotasSarasas)
            //{
            //    Console.WriteLine(item);
            //}
            //var sarasas1 = new List <string> { "Jonas", "Petras", "Vladas", "5", "11", "4", "aa", "NUL" };
            //var atrusiuotasSarasas = Methods.ASCIIsarasoGavimas(sarasas1);
            //foreach (var item in atrusiuotasSarasas)
            //{
            //    Console.WriteLine(item);
            //}
            var sarasas1 = new List<int> { 1, 2, 3, 4, 5 };
            var atrusiuotasSarasas = Methods.FaktorialoGavimas(sarasas1);
            foreach (var item in atrusiuotasSarasas)
            {
                Console.WriteLine(item);
            }


        }
    }
    public static class Methods
    {
        public static void ListoElementuIlgis(List  <string> sarasas)
        {
            
            foreach (string elementas in sarasas)
            {
                Console.WriteLine(elementas.Length);

            }
        }
        public static List<int> SarasoUzpildymas(List <int> sarasas)
        {
            for (int i = 1; sarasas.Count() < 50 ; i++)
            {
                sarasas.Add(i);
            }
            return sarasas;
        }
        public static double VidurkioSkaiciavimas(List <int> sarasas)
        {
            double suma = 0;
            
            foreach (int item in sarasas)
            {
                suma += item;
            }
            return suma / sarasas.Count();
        }
        public static List<int> DidesniuSkaiciuGavimas(List <int> sarasas)
        {
            List<int> result = new List<int>();
            foreach (int item in sarasas)
            {
                if(item > 10)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List <string> ASCIIsarasoGavimas(List <string> sarasas)
        {
            
            List<string> result = new List<string>();
            foreach (var item in sarasas)
            {
                int raidziuSuma = 0;
                foreach (char raide in item)
                {
                    raidziuSuma += (int)raide;
                   
                   
                }
                if(raidziuSuma % 2 == 0)
                {
                    result.Add(item);
                }
                
            }
            return result;
        }
        public static List <int> FaktorialoGavimas(List <int> sarasas)
        {
            var faktorialuSarasas = new List<int>();
            
            foreach (var item in sarasas)
            {
                int faktorialas = item;
                for (int i = item - 1 ; i > 0; i--)
                {
                    faktorialas *= i;                   
                }
                faktorialuSarasas.Add(faktorialas);
            }
            
            return faktorialuSarasas;
        }
    }
}
