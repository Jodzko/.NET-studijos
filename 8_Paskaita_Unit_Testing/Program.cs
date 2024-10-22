
//int length = Methods.GetTextLength("     test   ");
//Console.WriteLine(length);
using System;
using System.Threading.Channels;

Console.WriteLine("Iveskite pirma skaiciu:");
double skaicius1 = double.Parse(Console.ReadLine());
Console.WriteLine("Iveskite antra skaiciu:");
double skaicius2 = double.Parse(Console.ReadLine());
Console.WriteLine("Iveskite ka norite su jais daryti(+, -, /, *, ^, Sqrt(Ima pirma skaiciu)");
string veiksmas = Console.ReadLine();
double result = veiksmas switch
{

    "+" => result = Methods.Suma(skaicius1, skaicius2),
    "-" => result = Methods.Atimtis(skaicius1, skaicius2),
    "*" => result = Methods.Daugyba(skaicius1, skaicius2),
    "/" => result = Methods.Dalyba(skaicius1, skaicius2),
    "^" => result = Methods.KelimasLaipsniu(skaicius1, skaicius2),
    "Sqrt" => result = Methods.Saknis(skaicius1),
    _ => result = 0

};//Cia galima supaprastint iki 2 eiluciu su atskiru metodu GetAndValidateUserInput
Console.WriteLine(result);
Methods.Skaiciuotuvas(result, skaicius2);







public static class Methods
    {
    public static int GetTextLength(string text, bool includeLeadSpace = false)
    {
        if (!includeLeadSpace)
        {
            return text.Trim().Length;
        }
        else
        {
            return text.Length;
        }

    }
    public static double Skaiciuotuvas(double result, double skaiciu)
    {
        Console.WriteLine("Iveskite skaiciu:");
        skaiciu = double.Parse(Console.ReadLine());
        Console.WriteLine("Iveskite ka norite su jais daryti(+, -, /, *, ^, Sqrt(Ima pirma skaiciu)");
        string veiksmas = Console.ReadLine();       
        result = veiksmas switch
        {

            "+" => result = Suma(result, skaiciu),
            "-" => result = Atimtis(result, skaiciu),
            "*" => result = Daugyba(result, skaiciu),
            "/" => result = Dalyba(result, skaiciu),
            "^" => result = KelimasLaipsniu(result, skaiciu),
            "Sqrt" => result = Saknis(result),
            "g" => result = result


        };
        if (veiksmas == "g" )
        {
            Console.WriteLine("Galutinis rezultatas: " + result + " Isjungiame programa");
            return 0;
        }
        Console.WriteLine(result);
        Skaiciuotuvas(result, skaiciu);
        return result;
    }
    public static double Suma(double skaicius1, double skaicius2)
    {
        return skaicius1 + skaicius2;    
    }
    public static double Atimtis(double skaicius1, double skaicius2)
    {
        return skaicius1 - skaicius2;
    }
    public static double Daugyba(double skaicius1, double skaicius2)
    {
        return skaicius1 * skaicius2;
    }
    public static double Dalyba(double skaicius1, double skaicius2)
    {
        return skaicius1 / skaicius2;
    }
    public static double KelimasLaipsniu(double skaicius1, double skaicius2)
    {
        return Math.Pow(skaicius1, skaicius2);
    }
    public static double Saknis(double skaicius1)
    {
        return Math.Sqrt(skaicius1);
    }
}