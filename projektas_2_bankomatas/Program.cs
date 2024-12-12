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
            var bank = new Bank();
            var reader = File.ReadAllLines(bankFile);
            foreach (var item in reader)
            {
                string[] fileContent = item.Split(" ");
                bank.AddCard(new BankCard(int.Parse(fileContent[0]), int.Parse(fileContent[1]), fileContent[2], fileContent[3]));
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
            BankCard currentUser = new BankCard(0, 0, "", "");
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
                string input;
                while (true)
                {
                    Console.WriteLine("Enter your password: ");
                    var enter = Console.ReadLine();
                    if(enter != null)
                    {
                        input = enter;
                        break;                       
                    }
                }
                if (Hashing.CheckIfPasswordIsCorrect(input, foundCard.PasswordHashed, foundCard.StoredSalt))
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
                writer.WriteLine($"{x.CardNumber} {x.AccountBalance} {x.PasswordHashed} {x.StoredSalt}");
            });
            writer.Close();
        }

    }
}
