using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Iveskite is kokio jus miesto");
            //string n = Console.ReadLine();

            //if (n == "Vilnius")
            //{
            //    Console.WriteLine("Jus vilnietis");
            //}
            //else if (n == "Kaunas")
            //{
            //    Console.WriteLine("Jus Kaunietis");
            //}
            //else if (n == "Klaipeda")
            //{
            //    Console.WriteLine("Jus Klaipedietis");

            //}
            //else
            //{
            //    Console.WriteLine("Jus is kito miesto");
            //}

            //Console.WriteLine("Iveskite skaiciu: ");
            //int m = int.Parse(Console.ReadLine());



            //if (m == 100)
            //{
            //    Console.WriteLine("Jusu skaicius yra 100");
            //}
            //else if (m >= 100)
            //{
            //    Console.WriteLine("Jusu skaicius daugiau uz 100");
            //}
            //else
            //{
            //    Console.WriteLine("Juse skaicius maziau uz 100");
            //}
            //Console.WriteLine("Iveskite savaites diena");
            //int d = int.Parse(Console.ReadLine());
            //if (d == 1)
            //{
            //    Console.WriteLine("Siandien pirmadienis");
            //}
            //else if ( d == 2)
            //{
            //    Console.WriteLine("Siandien antradienis");
            //}
            //else if (d == 3)
            //{
            //    Console.WriteLine("Siandien treciadienis");
            //}
            //Console.WriteLine("Iveskite skaiciu: ");
            //int s = int.Parse(Console.ReadLine());
            //if (s % 2 == 0)
            //{
            //    Console.WriteLine("Jusu skaicius yra lyginis");
            //}
            //else if (s % 5 == 0)
            //{
            //    Console.WriteLine("Jusu skaicius dalinasi is 5");
            //}
            //else Console.WriteLine("Skaicius neatitinka jokiu salygu");

            //Console.WriteLine("Iveskite temperatura");
            //int t = int.Parse(Console.ReadLine());
            //if (t < 0)
            //{
            //    Console.WriteLine("Lauke salta");
            //}
            //else if (t >= 0)
            //{
            //    Console.WriteLine("Lauke vesu");
            //}
            //else if (t >20)
            //{
            //    Console.WriteLine("Lauke karsta");
            //}
            //Console.WriteLine("Kada siandien atsikelete?");
            //int a = int.Parse(Console.ReadLine());
            //if (a < 12)
            //{
            //    Console.WriteLine("Grazios dienos!");

            //}
            //else if ( a < 18)
            //{
            //    Console.WriteLine("Geros popietes!");
            //}
            //else if (a < 24)
            //{
            //    Console.WriteLine("Gero vakaro");
            //}
            //Console.WriteLine("Iveskite slaptazodi");
            //string or = "Mokomes";
            //string sl = Console.ReadLine();
            //if (sl == or)
            //{
            //    Console.WriteLine("Sekmingai prisijungete");
            //}
            //else if (sl == "Mellon")
            //{
            //    Console.WriteLine("Sekmingai prisijungete");
            //}
            //else if (sl == "01101001 01101110")
            //{
            //    Console.WriteLine("Nulauzta..");
            //}
            //else
            //    Console.WriteLine("Slaptazodis neteisingas, prasome bandyti dar karta..");
            //string skaicius = Console.ReadLine();
            //int sk = Convert.ToInt32(skaicius);

            //Bool salyga gali buti true arba false
            //int s = 5;
            //bool isLoggedIn = false;
            //if(!isLoggedIn){ //Su ! priekyje tikrinama ar nera tiesa(ar gauname false)
            //    Console.WriteLine("Jus esate atsijunge");
            //    bool isEven = s % 2 == 0 ; //Patikriname ar skaicius lyginis, gauname true arba false
            //    if (isEven)
            //    {

            //    }
            //    int age = 25;
            //    if (age >= 12 && age < 30)
            //    {
            //        Console.WriteLine("Jus skaitotes jaunimas");
            //    }
            // || reiskia, kad bent viena is salygu yra tiesa
            //int age = 20;
            //bool isInvited = true;
            //bool isVip = false;
            //if ((age>=20 && isInvited) || isVip)
            //{
            //    Console.WriteLine("Gali ieiti");
            //}

            //    Console.WriteLine("Iveskite savo amziu:");
            //    int a = int.Parse(Console.ReadLine());
            //    if (a < 18)
            //    {
            //        Console.WriteLine("Jums priklauso nepilnamecio akcija");
            //    }
            //    else if (a >= 18 && a < 65)
            //    {
            //        Console.WriteLine("Jus esate suauges");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Jums priklauso senjoro akcija");


            //}
            //Console.WriteLine("Iveskite metus");
            //int m = int.Parse(Console.ReadLine());
            //if (m % 4 == 0 && m % 100 != 0 || m % 400 == 0)
            //{
            //    Console.WriteLine("Tai yra keliamieji metai");
            //}
            //else
            //{
            //    Console.WriteLine("Tai nera keliamieji metai");
            //}
            //Console.WriteLine("Iveskite skaiciu: ");
            //int s = int.Parse(Console.ReadLine());
            //if ( s % 3 == 0 && s % 5 == 0)
            //{
            //    Console.WriteLine("Bazinga pop");
            //}
            //else if (s % 3 == 0)
            //{
            //    Console.WriteLine("Bazinga");

            //}
            //else if ( s % 5 == 0)
            //{
            //    Console.WriteLine("pop");
            //}
            //else
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("Iveskite pirmaji skaiciu");
            //int p = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite antraji skaiciu");
            //int a = int.Parse(Console.ReadLine());
            //if (p > 0 && a > 0)
            //{
            //    Console.WriteLine("Abu skaiciai teigiami");
            //}
            //else if (p > 0 || a > 0 )
            //{
            //    Console.WriteLine("vienas skaicius teigiamas");
            //}
            //else
            //{
            //    Console.WriteLine("Nei vienas nera teigiamas");
            //}
            //Console.WriteLine("Iveskite pirmaji skaiciu");
            //int p = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite antraji skaiciu");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite treciaji skaiciu");
            //int t = int.Parse(Console.ReadLine());
            //if ( p == a && a == t)
            //{
            //    Console.WriteLine("visi skaiciai lygus");
            //}
            //else if (a ==p || p == t || a == t)
            //{
            //    Console.WriteLine("Du skaiciai lygus");
            //}
            //else
            //{
            //    Console.WriteLine("Nei vienas nera lygus");
            //}
            //Console.WriteLine("Iveskite pirmaji skaiciu");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite antraji skaiciu");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite treciaji skaiciu");
            //int c = int.Parse(Console.ReadLine());
            //if (a>0 && b>0 && c > 0)
            //{
            //    int sum = a + b + c;
            //    Console.WriteLine(sum);
            //}
            //else if (a>0 && b>0)
            //{
            //    int sum = a + b;
            //    Console.WriteLine(sum);
            //}
            //else if (a > 0 && c > 0)
            //{
            //    int sum = a + c;
            //    Console.WriteLine(sum);
            //}
            //else if (b > 0 && c > 0)
            //{
            //    int sum = b + c;
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    Console.WriteLine("Neimanoma suskaiciuoti");
            //}
            //Console.WriteLine("Iveskite metus ir menesi: ");
            //string m = Console.ReadLine();
            //string subs1 = m.Substring(5,1);
            //if ((m[6] == '1' && subs1[0] == '0')  || (m[6] == '2' && subs1[0] == '0' ) || m[6] == '3')
            //{
            //    Console.WriteLine("Saltas laikotarpis");
            //}

            //else if (m[6] == '6' || m[6] == '7' || m[6] == '8')
            //{
            //    Console.WriteLine("Karstas laikotarpis");
            //}
            //else
            //{
            //    Console.WriteLine("Vidutinis laikotarpis");
            //}

            //Console.WriteLine("Iveskite pirmaji skaiciu");
            //int p = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite antraji skaiciu");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite treciaji skaiciu");
            //int t = int.Parse(Console.ReadLine());
            //if ((p > t && a > t) || ( p>a && t > a) || (a> p && t > p))
            //{
            //    Console.WriteLine("Galima sudaryti trikampi");
            //}
            //else
            //{
            //    Console.WriteLine("Negalima sudaryti trikampio");
            //}
            int o = 2;
            int b = 3;
            int k = 4;
            double ka = 0;
            Console.WriteLine("Obuolys - " + o + "eur");
            Console.WriteLine("Bananas - " + b + "eur");
            Console.WriteLine("Kriause - " + k + "eur");
            Console.WriteLine("Ka perkate?");
            string p = Console.ReadLine();
            
                if (p.ToLower() == "ob")
                {
                    ka = o + b;
                    Console.WriteLine("Krepselio kaina - " + ka + "eur");
                }
                else if (p.ToLower() == "ok")
                {
                    ka = o + k;
                    Console.WriteLine("Krepselio kaina - " + ka + "eur");
                }
                else if (p.ToLower() == "bk")
                {
                    ka = b + k;
                    Console.WriteLine("Krepselio kaina - " + ka + "eur");

                }
                else if (p.ToLower() == "oo")
                {
                    ka = (o + o) * 0.9;
                    Console.WriteLine("Krepselio kaina - " + ka + "eur");
                }
                else if (p.ToLower() == "bb")
                {
                    ka = (b + b) * 0.9;
                    Console.WriteLine("Krepselio kaina - " + ka + "eur");
                   
                }
                else if (p.ToLower() == "kk")
                {
                    ka = (k + k) * 0.9;
                    Console.WriteLine("Krepselio kaina - " + ka + "eur");
                    
                }
           
                Console.WriteLine("Ar turite lojalumo kortele? ");
                string a = Console.ReadLine();
                double sum = 0;
                bool kort = false;
                
                
                if (a.ToLower() == "taip")
                {
                    kort = true;
                sum = ka * 0.9;
            }
               else
            {
                
                
            }
            Console.WriteLine("Jusu galutine suma yra: " + sum + "eur");
                
            
                
                
            
            
                    


        } 
        
    }
}
