using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace projektas_2_bankomatas
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankFile = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Bankomatas.txt";
            var transactionsFile = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Transactions.txt";
            //var card1 = new BankCard(123456789, 1500000, "Slaptazodis1");
            //var card2 = new BankCard(123456790, 250000, "Slaptazodis2");
            //var card3 = new BankCard(123456791, 100000, "Slaptazodis3");
            //var card4 = new BankCard(123456792, 1000000, "Slaptazodis4");
            //var card5 = new BankCard(123456793, 50000, "Slaptazodis5");
            //var bank = new Bank();
            //bank.AddCard(card1);
            //bank.AddCard(card2);
            //bank.AddCard(card3);
            //bank.AddCard(card4);
            //bank.AddCard(card5);

            //var writer = new StreamWriter(bankFile);
            //bank.ListOfCardsInBank.ForEach(x =>
            //{
            //    writer.WriteLine($"{x.CardNumber}   {x.AccountBalance}  {x.Password}");


            //});
            //writer.Close();
            //Console.WriteLine(Hashing.ToSHA256("Slaptazodis1"));
            //Console.WriteLine(Hashing.ToSHA256("Slaptazodis2"));
            //Console.WriteLine(Hashing.ToSHA256("Slaptazodis3"));
            //Console.WriteLine(Hashing.ToSHA256("Slaptazodis4"));
            //Console.WriteLine(Hashing.ToSHA256("Slaptazodis5"));
            //Hashing.GenerateSalt();
            //Console.WriteLine(Hashing.HashPasswordWithSalt("Slaptazodis1"));
            //Console.WriteLine(Hashing.HashPasswordWithSalt("Slaptazodis2"));
            //Console.WriteLine(Hashing.HashPasswordWithSalt("Slaptazodis3"));
            //Console.WriteLine(Hashing.HashPasswordWithSalt("Slaptazodis4"));
            //Console.WriteLine(Hashing.HashPasswordWithSalt("Slaptazodis5"));
            var bank = new Bank();
            var reader = File.ReadAllLines(bankFile);
            foreach (var item in reader)
            {
                string[] fileContent = item.Split(" ");
                bank.AddCard(new BankCard(int.Parse(fileContent[0]), int.Parse(fileContent[1]), fileContent[2]));
            }
            var inputingCard = true;
            var inputtedCard = 0;
            while (inputingCard)
            {
                Console.Clear();
                Console.WriteLine("Enter a 9 digit card number: ");
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    continue;
                }
                else
                {
                    var length = input.ToString().Length;
                    if (length == 9)
                    {
                        inputtedCard = input;
                        inputingCard = false;                                              
                    }
                    else
                    {
                        continue;
                    } 
                }
            }
            BankCard currentUser = new BankCard(0, 0, "");
            //SingleOrDefault panaudot 
            var foundCard = bank.ListOfCardsInBank.SingleOrDefault(x => x.CardNumber == inputtedCard);
            var incorrectCount = 0;
            var correctInput = true;
            while (correctInput)
            {
                if(foundCard == null)
                {
                    Console.WriteLine($"Didn't find a card with the number {inputtedCard}. You have to go to the bank to add your account.");
                    correctInput = false;
                    break;
                }
                Console.Clear();
                Console.WriteLine("Enter your password: ");
                var input = Console.ReadLine();
                if (Hashing.ToSHA256(input) == foundCard.Password)
                {
                    correctInput = false;
                    Console.WriteLine("Successfully logged in!");
                    Console.WriteLine($"Account balance: {foundCard.AccountBalance}");
                    currentUser = foundCard;
                    Console.ReadLine();
                    Menu.OpenMenu(currentUser);
                }
                else
                {
                    Console.WriteLine("Incorrect password, try again.");
                    Console.ReadLine();
                    incorrectCount++;
                }
                if (incorrectCount == 3)
                {
                    Console.WriteLine("Too many login attempts, shutting down.");
                    break;
                }
            }
            WriteNewInformation(bank, bankFile);            
        }
        public static void WriteNewInformation(Bank bank, string path)
        {
            var writer = new StreamWriter(path);
            bank.ListOfCardsInBank.ForEach(x =>
            {
                writer.WriteLine($"{x.CardNumber} {x.AccountBalance} {x.Password}");
            });
            writer.Close();
        }

    }
}
