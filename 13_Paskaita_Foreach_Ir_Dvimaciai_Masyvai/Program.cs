using System.Diagnostics.CodeAnalysis;

namespace _13_Paskaita_Foreach_Ir_Dvimaciai_Masyvai
{
    
        public class Program
    {

        static void Main(string[] args)
        {
            string[] cars = { "Toyota", "BMW", "Audi" };

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //foreach(string car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //Console.WriteLine("Iveskite skaicius: ");
            //int input = int.Parse(Console.ReadLine());
            //int[] skaiciai = { -2, 2, -3, -4, 5 } ;
            //int vidurkis = Methods.VidurkioSkaiciavimas(Skaiciai);
            //Console.WriteLine(vidurkis);
            //int[] teigiamiSkaiciai = Methods.TeigiamuSkaiciuGrazinimas(skaiciai);
            //for (int i = 0; i < teigiamiSkaiciai.Length; i++)
            //{
            //    Console.WriteLine(teigiamiSkaiciai[i]);
            //}
            ////Console.WriteLine("Iveskite eiluciu kieki: ");
            ////int eilutes = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Iveskite stulpeliu kieki: ");
            ////int stulpeliai = int.Parse(Console.ReadLine());
            ////int[,] matrica = new int[eilutes, stulpeliai];
            ////for (int i = 0; i < matrica.GetLength(0); i++)
            ////{

            ////    for (int j = 0; j < matrica.GetLength(1); j++)
            ////    {
            ////        Console.WriteLine("Iveskite skaiciu: ");
            ////        int skaicius = int.Parse(Console.ReadLine());
            ////        matrica[i, j] = skaicius;

            ////    }
            ////}
            ////for (int i = 0; i < matrica.GetLength(0); i++)
            ////{
            ////    for (int j = 0; j < matrica.GetLength(1); j++)
            ////    {
            ////        Console.Write(matrica[i, j] + "\t");
            ////    }
            ////    Console.WriteLine();
            ////}
            int stulpelis;
            int eilute;
            int[,] dvimatisMasyvas = new int[2, 2];
            dvimatisMasyvas[0, 0] = -100;
            dvimatisMasyvas[0, 1] = -25;

            dvimatisMasyvas[1, 0] = -20;
            dvimatisMasyvas[1, 1] = -13;

            int didziausias = Methods.DidziausioSkaicioRadimas(dvimatisMasyvas, out eilute,out stulpelis);
            Console.WriteLine("Didziausias skaicius masyve yra: " + didziausias);
            for (int i = 0; i < dvimatisMasyvas.GetLength(0); i++)
            {
                for (int j = 0; j < dvimatisMasyvas.GetLength(1); j++)
                {
                    if(didziausias == dvimatisMasyvas[i, j])
                    {
                        Console.WriteLine("Jo pozicija yra " + eilute + stulpelis);
                    }
                }
            }






        }


    }
    public static class Methods
    {
        public static int VidurkioSkaiciavimas(int[] ivestiSkaiciai)
        {
            int suma = 0;
            int vidurkis = 0;
            foreach (int skaicius in ivestiSkaiciai)
            {
                suma += skaicius;
            }
            vidurkis = suma / (ivestiSkaiciai.Length);
            return vidurkis;
        }
        public static int[] TeigiamuSkaiciuGrazinimas(int[] masyvas)
        {
            int k = 0;
            int[] teigiamiSkaiciai = new int[SveikuSkaiciuKiekisMasyve(masyvas)];
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > 0)
                {                   
                    teigiamiSkaiciai[k] = masyvas[i];
                    k++;
                }
                
            }
            return teigiamiSkaiciai;
        }
        public static int SveikuSkaiciuKiekisMasyve(int[] masyvas)
        {
            int kiekis = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > 0)
                {
                    kiekis++;
                }
            }
            return kiekis;
        }
        public static int DidziausioSkaicioRadimas(int[,] masyvas, out int eilute, out int stulpelis)
        {
            eilute = 0;
            stulpelis = 0;
            
            int didziausias = masyvas[0, 0];
            for (int i = 0; i < masyvas.GetLength(0); i++)
            {

                for (int j = 0; j < masyvas.GetLength(1); j++)
                {
                    if (masyvas[i, j] > didziausias)
                    {
                        didziausias = masyvas[i, j];
                        eilute = i;
                        stulpelis = j;
                    }
                }
            }
            
            
            return didziausias;
        }
        
    }
}
