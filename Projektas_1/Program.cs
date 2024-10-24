namespace Projektas_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RaudonaSpalva();
            Console.WriteLine("Sveiki prisijungę į pokemonų žaidimą!");
            Console.WriteLine("Spauskite bet kokį klavišą, kad pradėti.");
            OriginaliSpalva();
            Console.WriteLine("Pasirinkite kur eisite: ");
            Console.WriteLine("1 - Į žaliąjį mišką");
            Console.WriteLine("2 - Į požemius");
            int kelias = int.Parse(Console.ReadLine());
            if(kelias == 1)
            {

            }
            if(kelias == 2)
            {

            }
        }
        public static void RaudonaSpalva()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public static void OriginaliSpalva()
        {
            Console.ResetColor();
        }
    }

}
