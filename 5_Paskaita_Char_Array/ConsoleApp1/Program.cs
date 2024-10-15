namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //char symbol = 'x'; // Char saugo viena simboli, 16bitu, butinai viengubos kabutes
            //string text = "Tekstas";
            //text.Concat("tekstas2");



            //char[] symbols = text.ToCharArray();
            //symbols[0] = 'X';
            //string changedText = new string(symbols);

            //Console.WriteLine(changedText);

            //char changedTextSymbol = changedText[3];
            //Console.WriteLine(changedTextSymbol);


            //string greeting = "Labas";
            //string textWithChangedSymbol = greeting.Replace('a', 'x');
            //Console.WriteLine(textWithChangedSymbol);

            //Console.WriteLine("Iveskite teksta");
            //string zodis = Console.ReadLine();
            //Console.WriteLine(char.ToUpper(zodis[0]) + zodis.Substring(1));


            //Console.WriteLine("Iveskite teksta");
            //string tekstas = Console.ReadLine();
            //char[] pakeistas = tekstas.ToCharArray();
            //pakeistas[2] = 'g';
            //pakeistas[4] = 'b';
            //pakeistas[6] = '*';
            //pakeistas[8] = 'x';
            //pakeistas[10] = 'w';
            //string naujasTekstas = new string(pakeistas);

            //Console.WriteLine(naujasTekstas);
            //Console.WriteLine(new string(input)); //Galima taip supaprastint


            // Uzduotis 
            //Console.WriteLine("Iveskite 5 simboliu ilgumo teksta");
            //string text = Console.ReadLine();
            //char[] tekstas = text.ToCharArray();
            //if (text.Length > 5)
            //{
            //    Console.WriteLine("Ivestas per ilgas tekstas");
            //}
            //else if (text.Length < 5)
            //{
            //    Console.WriteLine("Ivestas tekstas per trumpas");
            //}
            //else
            //{
            //    Console.WriteLine("Iveskite kodavimo zinute");
            //string kodas = Console.ReadLine();


            //    string uzkoduotas = "";
            //    for (int i = 0; i < tekstas.Length; i++)
            //    {
            //        uzkoduotas = uzkoduotas + (tekstas[i] + kodas.ToString());
            //    }
            //    Console.WriteLine(uzkoduotas);
            //     }




            // kitas dalykas
            //string text1 = "123A";
            //int number;
            //if(int.TryParse(text1, out number))
            //{
            //    Console.WriteLine("Conversion successful: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Conversion unsuccessful");
            //}


            //    Console.WriteLine("Iveskite sakini");
            //    string sakinys = Console.ReadLine();
            //    string pakeistasSakinys = sakinys.Replace("a", "uo");
            //    string pakeistasSakinys1 = pakeistasSakinys.Replace('i', 'e');
            //    Console.WriteLine(pakeistasSakinys1);
            //
            //Console.WriteLine("Iveskite dainos zodzius:");
            //string daina = Console.ReadLine();
            //Console.WriteLine("Iveskite zodzius, kuriuos norite pakeisti");
            //string kaKeiciam = Console.ReadLine();
            //Console.WriteLine("Iveskite i ka norite pakeisti");
            //string kuoKeiciam = Console.ReadLine();
            //string pakeista = daina.Replace(kaKeiciam, kuoKeiciam);
            //Console.WriteLine(pakeista);

            //Console.WriteLine("Iveskite kiek jums metu:");
            //double metai = int.Parse(Console.ReadLine());
            //double dienos = metai / 365;
            //double savaites = metai / 52.1429;
            //double menesiai = metai / 12;
            //Console.WriteLine("Iki 90ties metu jums liko: ");
            //Console.WriteLine((90*365) - dienos + "dienu");
            //Console.WriteLine((90*52.149) - savaites + "savaites");
            //Console.WriteLine((90 * menesiai) - menesiai + "menesiai");
            //Console.WriteLine(90-metai + "metai");

            //Console.WriteLine("Iveskite zodi");
            //string zodis = Console.ReadLine();
            //char pirmaraide = char.ToUpper(zodis[0]);
            //if (zodis[0] == pirmaraide)
            //{
            //    Console.WriteLine(zodis.ToUpper());
            //}
            //else
            //{
            //    Console.WriteLine(char.ToUpper(zodis[0]) + zodis.Substring(1));
            //}
            //Console.WriteLine("Iveskite zodi");
            //string zodis = Console.ReadLine();
            //if (!zodis.Contains('a'))
            //{
            //    Console.WriteLine("Simbolis a nerastas");
            //}
            //else
            //{
            //int a = zodis.IndexOf('a');
            //    Console.WriteLine(zodis + " a simbolio indeksas: " + a);
            //}

            //Console.WriteLine("Iveskite zodi");
            //string zodis = Console.ReadLine();
            //if (zodis == "labas")
            //{
            //    string atbulai = new string(zodis.Reverse().ToArray());
            //    Console.WriteLine(atbulai);
            //}
            //else
            //{
            //    Console.WriteLine(zodis);
            //}


            int duonaKaina = 2;
            int pilnoGrudoKaina = 3;
            int LDydisKaina = 2;
            int saliamisKaina = 2;
            int fetaKaina = 1;
            double pupelesKaina = 0.5;
            double padazasKaina = 0.5;
            double pomidorasKaina = 0.75;
            double agurkasKaina = 0.75;
            double bekonasKaina = 2;
            double ciliKaina = 0.5;
            double sviestasKaina = 0.5;
            double zirneliaiKaina = 0.5;
            double mocarelaKaina = 1;
            double parmezanasKaina = 1;
            double rakletasKaina = 1;
            double galutine = 0;

            Console.WriteLine("Pasirinkite duona");
            string duona = Console.ReadLine();
            if (duona.ToLower() == "pilno")
            {
                galutine = galutine + pilnoGrudoKaina;
            }
            if (duona.ToLower() == "paprasta")
            {
                galutine = galutine + duonaKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("Ar deti saliami?");
            string salamis = Console.ReadLine();
            bool salami = false;
            if (salamis.ToLower() == "taip")
            {
                salami = true;
                galutine = galutine + saliamisKaina;

            }
            Console.WriteLine(galutine);
            Console.WriteLine("Koki suri deti?");
            string suris = Console.ReadLine();
            bool feta = false;
            bool mocarela = false;
            bool parmezanas = false;
            double surisKaina = 0;
            if (suris == "feta")
            {
                feta = true;
                galutine = galutine + fetaKaina;
                surisKaina = fetaKaina;
            }
            else if (suris == "mocarela")
            {
                mocarela = true;
                galutine = galutine + mocarelaKaina;
                surisKaina = mocarelaKaina;

            }
            else if (suris == "parmezanas")
            {
                parmezanas = true;
                galutine = galutine + parmezanasKaina;
                surisKaina = parmezanasKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("Ar deti pupeles?");
            string pupos = Console.ReadLine();
            bool pupeles = false;
            if (pupos == "taip")
            {
                pupeles = true;
                galutine = galutine + pupelesKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("Ar deti padazo?");
            string padazas = Console.ReadLine();
            bool padaz = false;
            if(padazas == "taip")
            {
                padaz = true;
                galutine = galutine + padazasKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("ar deti pomidora?");
            string pomidoras = Console.ReadLine();
            bool pomid = false;
            if (pomidoras == "taip")
            {
                pomid = true;
                galutine = galutine + pomidorasKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("Ar deti agurko?");
            string agurkas = Console.ReadLine();
            bool agurk = false;
            if (agurkas == "taip")
            {
                agurk = true;
                galutine = galutine + agurkasKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("Ar deti bekono?");
            string bekonas = Console.ReadLine();
            bool bekon = false;
            if (bekonas == "taip")
            {
                bekon = true;
                galutine = galutine + bekonasKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("ar deti pipiru?");
            string pipirai = Console.ReadLine();
            bool pipir = false;
            if (pipirai == "taip")
            {
                pipir = true;
                galutine = galutine + ciliKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("ar deti sviesto?");
            string sviestas = Console.ReadLine();
            bool sviest = false;
            if (sviestas == "taip")
            {
                sviest = true;
                galutine = galutine + sviestasKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("ar deti zirneliu?");
            string zirneliai = Console.ReadLine();
            bool zirn = false;
            if (zirneliai == "taip")
            {
                zirn = true;
                galutine = galutine + zirneliaiKaina;

            }
            Console.WriteLine(galutine);
            Console.WriteLine("ar deti rakleta?");
            string rakletas = Console.ReadLine();
            bool raklet = false;
            if (rakletas == "taip")
            {
                raklet = true;
                galutine = galutine + rakletasKaina;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("Koks dydzio noresite?");
            string dydis = Console.ReadLine();
            if (dydis == "didelio")
            {
                galutine = galutine * LDydisKaina;
            }
            else if (dydis == "vidutinio" || dydis == "mazo")
            {
                galutine = galutine * 1;
            }
            Console.WriteLine(galutine);
            Console.WriteLine("Jusu uzsakymas:");
            if (dydis == "didelio")
            {
                Console.WriteLine("L dydzio sumustinis");

            }
            if  (duona == "pilnogrudo")
            {
                Console.WriteLine("Pilno grudo duona " + pilnoGrudoKaina);
            }
            if ( duona == "paprasta")
            {
                Console.WriteLine("paprasta duona " + duonaKaina);
            }
            if(salami)
            {
                Console.WriteLine("Salamis " + saliamisKaina);
            }
            if (feta )
            {
                Console.WriteLine("Feta " + surisKaina);
            }
            else if(mocarela)
            {
                Console.WriteLine("Mocarela " + surisKaina);
            }
            else if(parmezanas)
            {
                Console.WriteLine("Parmezanas " + surisKaina);
            }
            if(pupeles )
            {
                Console.WriteLine("Pupeles " + pupelesKaina);
            }
            if(padaz )
            {
                Console.WriteLine("Pupeles " + padazasKaina);
            }
            if (pomid)
            {
                Console.WriteLine("Pomidorai " + pomidorasKaina);
            }
            if (agurk)
            {
                Console.WriteLine("Agurkas " + agurkasKaina);
            }
            if (bekon)
            {
                Console.WriteLine("Bekonas " + bekonasKaina);
            }
            if (pipir)
            {
                Console.WriteLine("Pipirai " + ciliKaina);
            }
            if (sviest)
            {
                Console.WriteLine("Sviestas " + sviestasKaina);
            }
            if (zirn)
            {
                Console.WriteLine("Zirneliai " + zirneliaiKaina);
            }
            if (raklet)
            {
                Console.WriteLine("Rakletas " + rakletasKaina);
            }
            Console.WriteLine("Kaina: " + galutine + " Euru");
        }
    }
}
