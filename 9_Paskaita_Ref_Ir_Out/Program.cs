namespace _9_Paskaita_Ref_Ir_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int y = 10;
            //int x = 0;
            //Swap(ref y,ref x);
            //Console.WriteLine("y reiksme: " + y + " x reiksme: " + x);
            //IncrementByN(ref x);
            //Console.WriteLine(x);
            //Console.WriteLine("Iveskite fraze: ");
            //string fraze = Console.ReadLine();          
            //TrimAndCapitalize(ref fraze);
            //Console.WriteLine(fraze);
            //VardasPavarde(out string vardas, out string pavarde);
            //Console.WriteLine("Jusu vardas: " + vardas + " Jusu pavarde: " + pavarde);

            //Skaicius(out int skaicius);
            Divide(out double x, out double y);
            
            
        }
        static void ChangeValue(ref int x)
        {
            x = 200;
        }
        static void Swap(ref int y,ref int x)
        {
            int z = x;
            x = y;           
            y = z;   
        }
        static void IncrementByN(ref int x)
        {
            while (x <= 20)
            {
                Console.WriteLine(x);
                x += 2;
            }
                
            }
        static void TrimAndCapitalize(ref string fraze)
        {
            string nauja = fraze.Trim();
            string pirmaraide = (char.ToUpper(nauja[0]) + nauja.Substring(1));
            fraze = pirmaraide;
            
        }
        static void VardasPavarde(out string vardas, out string pavarde)
        {
            Console.WriteLine("Iveskite savo varda: ");
            vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo pavarde: ");
            pavarde = Console.ReadLine();
        }
        static void Skaicius(out int skaicius)
        {
           
            Console.WriteLine("Iveskite skaiciu: ");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int result);
                int sk = Convert.ToInt32(input);
                while (success && sk < 100)
                {
                   
                Console.WriteLine("Iveskite kita skaiciu: ");
                input = Console.ReadLine();
                success = int.TryParse(input, out result);
                sk = result;
                continue;

            }
            Console.WriteLine("Isjungiame programa");
            skaicius = 1;
            
            
        }
       static void Divide(out double x, out double y)
        {
            Console.WriteLine("Iveskite pirma skaiciu: ");
            x = double.Parse(Console.ReadLine());          
            Console.WriteLine("Iveskite antra skaiciu: ");
            y = double.Parse(Console.ReadLine());
            double result = x / y;           
            int skaicius1 = Convert.ToInt32(x);
            int skaicius2 = Convert.ToInt32(y);
            int liekana = skaicius1 % skaicius2;
            int sveikoji = skaicius1 / skaicius2;          
            x = sveikoji;
            y = liekana;
            Console.WriteLine($"Sveikoji dalis: {x}\nLiekana: {y}");
            Divide(out x, out y);
        }
            
    }
}
