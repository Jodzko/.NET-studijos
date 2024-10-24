namespace _12_Paskaita_Masyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Pavyzdziai
            //int[] emptyArray = new int[10];
            //int[] arrayWithInitialValue = { 1, 2, 3, 4, 5, 88, 115, 999 };

            //Console.WriteLine(emptyArray[5]);//Pasiekimas

            //arrayWithInitialValue[arrayWithInitialValue.Length - 1] = 23;
            //Console.WriteLine(arrayWithInitialValue[7]);
            //string[] sentences = { "abc", "text", "random" };
            //for (int i = 0; i < sentences.Length; i++)
            //{
            //    Console.WriteLine(sentences[i]);
            //}

            //for (int i = 0; i < emptyArray.Length; i++)
            //{
            //    emptyArray[i] = i * i;
            //    Console.WriteLine(emptyArray[i]);
            //}



            ////Uzduotys
            int[] arrayThreeElements = { 1, 2, 3, 4, 5, 6 };
            //Kvadratu(arrayThreeElements);
            //Console.WriteLine(arrayThreeElements);           
            ////int suma = Suma(arrayThreeElements);
            ////Console.WriteLine("Array eleementu suma: " + suma);
            //////int didziausias = DidziausiasSkaicius(arrayThreeElements);
            //////Console.WriteLine("Didziausias array skaicius: " + didziausias);
            //MasyvasAtbulai(arrayThreeElements);
            ////Console.WriteLine("Iveskite zodi");
            ////string input = Console.ReadLine();
            ////ZodzioPadalinimas(input);
            //Console.WriteLine("Iveskite sakini: ");
            //string sakinys = Console.ReadLine();
            //PirmaRaide(sakinys);
            //Console.WriteLine(sakinys[0]);
            Console.WriteLine("Iveskite sakini: ");
            string sakinys = Console.ReadLine();
            PirmaRaide(sakinys);
            Console.WriteLine(sakinys[sakinys.Length - 1]);




        }

        public static int[] Kvadratu(int[] arrayThreeElements)
        {
            
            for (int i = 0; i < arrayThreeElements.Length; i++)
            {
                arrayThreeElements[i] = arrayThreeElements[i] * arrayThreeElements[i];
                Console.WriteLine(arrayThreeElements[i]);
                
            }
            return arrayThreeElements;
            
        }
        public static int Suma(int[] ArraySuma)
        {
            int suma = 0;
            for (int i = 0; i < ArraySuma.Length; i++)
            {
                suma += ArraySuma[i];
            }
            return suma;
        }
        public static int DidziausiasSkaicius(int[] ArrayDidziausias)
        {
            int didziausias = 0;
            for (int i = 0; i < ArrayDidziausias.Length; i++)
            {
                
                if (ArrayDidziausias[i] > didziausias)
                {
                    didziausias = ArrayDidziausias[i];
                }
            }
            return didziausias;
        }
        public static void MasyvasAtbulai(int[] MasyvasAtbulai)
        {           
            for (int i = MasyvasAtbulai.Length - 1; i < MasyvasAtbulai.Length ; i--)
            {
                Console.WriteLine(MasyvasAtbulai[i]);
            }                      
        }
        public static void RezultatauSpausdinimas(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static char[] ZodzioPadalinimas(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
            return chars;
        }
        public static char[] PirmaRaide(string sentence)
        {
            char[] chars = sentence.ToCharArray();

            return chars;
            
        }
        public static char[] PaskutineRaide(string sentence)
        {
            char[] chars = sentence.ToCharArray();

            return chars;

        }
    }

}
