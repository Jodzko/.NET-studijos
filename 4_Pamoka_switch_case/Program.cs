// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Switch case ir if yra tas pats dalykas, switch geriau iskaitomas

//int day = 3;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Pirmadienis");
//        break;
//    case 2:
//        Console.WriteLine("Antradienis");
//        break;
//    case 3:
//        Console.WriteLine("Treciadienis");
//        break;
//    //Ir taip toliau
//    default:
//        Console.WriteLine("Neteisinga diena");
//        break;
//}
//Pattern matchingas( Jame viduje galima naudoti tik funkcijas, kurios kazka grazina)
//int operation = 1;
//var result = operation switch
//{
//    1 => "Case 1",
//    2 => "Case 2",
//    3 => "Case 3",
//    4 => "Case 4",
//    _ => "Default case"
//};
//Console.WriteLine(result); // Atspausdins reiksme


//Console.WriteLine("Iveskite savaites diena");
//int s = int.Parse(Console.ReadLine());
//string diena = s switch
//{
//    1 => "Pirmadienis",
//    2 => "Antradienis",
//    3 => "Treciadienis",
//    4 => "Ketvirtadienis",
//    5 => "Penktadienis",
//    6 => "Sestadienis",
//    7 => "Sekmadienis",
//    _ => "Neteisinga diena"
//};
//Console.WriteLine(diena);

//Console.WriteLine("Iveskite savo amziu");
//int a = int.Parse(Console.ReadLine());
//string b = a switch
//{
//    >= 7 and <= 18 => "Moksleivis",
//    >= 19 and <= 25 => "Studentas",
//    >= 26 and <= 65 => "Darbuotojas",
//    > 66 => "Studentas",
//    _ => "Jauniklis"
//};
//Console.WriteLine(b);
//Console.WriteLine("Iveskite menesio numeri: ");
//int d = int.Parse(Console.ReadLine());
//string p = d switch
//{
//    1 => "Sausis",
//    2 => "Vasaris",
//    3 => "Kovas",
//    4 => "Balandis",
//    5 => "Geguze",
//    6 => "Birzelis",
//    7 => "Liepa",
//    8 => "Rugpjutis",
//    9 => "Rugsejis",
//    10 => "Spalis",
//    11 => "Lapkritis",
//    12 => "Gruodis",
//    _ => "Skaiciu nepazisti?"
//};
//Console.WriteLine(p);
// Figuros plotas
//Console.WriteLine("Iveskite figura");
//string figura = Console.ReadLine().ToLower();
//if (figura == "trikampis")
//{
//    Console.WriteLine("Iveskite aukstine");
//    int aukstine = int.Parse(Console.ReadLine());
//    Console.WriteLine("Iveskite pagrinda");
//    int pagrindas = int.Parse(Console.ReadLine());
//    double plotas = (aukstine * pagrindas) / 2;
//    Console.WriteLine("Figuros plotas: " + plotas);
//}
//else if (figura == "kvadratas")
//{
//    Console.WriteLine("Iveskite krastine");
//    int krastine = int.Parse(Console.ReadLine());
//    double plotas1 = krastine * krastine;
//    Console.WriteLine("Figuros plotas: " + plotas1);
//}
//else if (figura == "staciakampis")
//{
//    Console.WriteLine("Iveskite krastine");
//    int krast = int.Parse(Console.ReadLine());
//    Console.WriteLine("Iveskite kita krastine");
//    int krast2 = int.Parse(Console.ReadLine());
//    double plotas2 = krast * krast2;
//    Console.WriteLine(plotas2);
//}
//else if (figura == "apskritimas")
//{
//    Console.WriteLine("Iveskite spindulio ilgi ");
//    int spind = int.Parse(Console.ReadLine());
//    double plotas3 = 2 * Math.PI * (spind * spind);
//    Console.WriteLine("Figuros plotas: " + plotas3);
//}
//else
//{
//    Console.WriteLine("Kazka ne taip ivedete");
//}
///////Elemento uzduotis
//Console.WriteLine("Iveskite elementa");
//string elementas = Console.ReadLine();
//string savybe = elementas.ToLower() switch
//{
//    "ugnis" => "Karstas",
//    "vanduo" => "Slapia",
//    "oras" => "vejuota",
//    "zeme" => "purvina",
//    "eteris" => "negyvas eteris",
//    _ => "Neteisingas elementas"
//};
//Console.WriteLine(savybe);
//// Universiteto uzduotis
Console.WriteLine("Pasirinkite specialybe");
string specialybe = Console.ReadLine().ToLower();

Console.WriteLine("Iveskite savo vidurki");
double vidurkis = double.Parse(Console.ReadLine());

Console.WriteLine("Iveskite kiek surinkote is egzamino");
double egz = double.Parse(Console.ReadLine());

Console.WriteLine("Ar dalyvavote olimpiadoje?");
string ats = Console.ReadLine().ToLower();

bool olimp = false;
if (ats == "taip")
{
    olimp = true;
}
if ((specialybe == "matematika" || specialybe == "informatika" || specialybe == "biologija" || specialybe == "chemija")  && vidurkis >= 8 && egz >= 80 && olimp)
{
    Console.WriteLine("Jusu sansai dideli");
}
else if ((specialybe == "matematika" || specialybe == "informatika" || specialybe == "biologija" || specialybe == "chemija") && vidurkis >= 7 && egz >= 70 && olimp)
{
    Console.WriteLine("Jus sansu tikrai turite");
}
else if ((specialybe == "matematika" || specialybe == "informatika" || specialybe == "biologija" || specialybe == "chemija") && vidurkis >=6 && egz >= 60 && olimp)
{
    Console.WriteLine("Sansai menki...");
}
else if ((specialybe == "matematika" || specialybe == "informatika" || specialybe == "biologija" || specialybe == "chemija") && vidurkis >= 6 && egz >= 60 && !olimp)
{
    Console.WriteLine("Sansu neturite");
}



