namespace projektas_2_bankomatas
{
    public class BankCardOperations : BankCard, IMoneyOperations
    {
        static DateTime lastResetDate = DateTime.Now.Date;
        private readonly string TransactionsPath = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Transactions.txt";
        private int NumberOfTransactions = 0;
        private static BankCardOperations _instance;
        private BankCardOperations()
        {

        }
        private BankCardOperations(int cardNumber, decimal accountBalance, string password) : base(cardNumber, accountBalance, password)
        {
        }
        public static BankCardOperations Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BankCardOperations();
                }
                return _instance;
            }
        }
        public decimal RemoveMoney(decimal amount)
        {
            AccountBalance = AccountBalance - amount;
            using (StreamWriter sw = new StreamWriter(TransactionsPath, true))
            {
                sw.WriteLine($"{DateTime.Now.Date} Card with the number: {CardNumber} removed {amount} from the account");
            }
            return AccountBalance;
        }
        public decimal AddMoney(decimal amount)
        {
            AccountBalance = AccountBalance + amount;
            using (StreamWriter sw = new StreamWriter(TransactionsPath, true))
            {
                sw.WriteLine($"{DateTime.Now.Date} Card with the number: {CardNumber} added {amount} to the account");
            }
            return AccountBalance;
        }
        public void Menu(BankCard card)
        {
            CheckAndResetTransactions();
            var choice = 0;
            var choosing = true;

            while (choosing)
            {
                Console.Clear();
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Show balance of the account");
                Console.WriteLine("2. Show 5 last transactions");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Add money");
                Console.WriteLine("5. Take out card");
                int.TryParse(Console.ReadLine(), out choice);
                var isAmountIncorrect = true;
                switch (choice)
                {
                    case 1:

                        Console.WriteLine($"Your account balance:  {card.AccountBalance}");
                        AnotherTransaction(out choosing);
                        break;
                    case 2:
                        var transactionDisplayCount = 0;
                        var display = File.ReadAllLines(TransactionsPath);
                        Array.Reverse(display);
                        foreach (var item in display)
                        {
                            string[] itemsInFile = item.Split(" ");
                            if (transactionDisplayCount < 5 && int.Parse(itemsInFile[6]) == card.CardNumber)
                            {
                                Console.WriteLine(item);
                                transactionDisplayCount++;
                                if (transactionDisplayCount == 5)
                                {
                                    AnotherTransaction(out choosing);
                                }
                            }
                        }
                        if (transactionDisplayCount != 5)
                        {
                            AnotherTransaction(out choosing);
                        }
                        break;
                    case 3:
                        isAmountIncorrect = true;
                        while (isAmountIncorrect)
                        {
                            LimitOfTransactionsReached(out isAmountIncorrect);
                            Console.WriteLine("Enter the amount you want to withdraw: ");
                            if (!int.TryParse(Console.ReadLine(), out int input))
                            {
                                continue;
                            }
                            if (input > 1000)
                            {
                                Console.WriteLine("The maximum amount to withdraw is 1000");
                                Console.ReadLine();
                            }
                            if (NumberOfTransactions < 10)
                            {
                                RemoveMoney(input);
                                NumberOfTransactions++;
                                Console.WriteLine($"Transaction complete! Please take your {input} Euros.");
                                AnotherTransaction(out choosing);
                                isAmountIncorrect = false;
                            }
                        }
                        break;
                    case 4:
                        isAmountIncorrect = true;
                        while (isAmountIncorrect)
                        {
                            LimitOfTransactionsReached(out isAmountIncorrect);
                            Console.WriteLine("Enter the amount you want to Add: ");
                            if (!int.TryParse(Console.ReadLine(), out int input))
                            {
                                continue;
                            }
                            if (NumberOfTransactions < 10)
                            {
                                AddMoney(input);
                                NumberOfTransactions++;
                                Console.WriteLine($"Transaction complete! Added {input} Euros to your account.");
                                AnotherTransaction(out choosing);
                                isAmountIncorrect = false;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Please take your card, have a nice day!");
                        choosing = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice, try again");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void CheckAndResetTransactions()
        {
            if (DateTime.Today.Date > lastResetDate)
            {
                NumberOfTransactions = 0;
                lastResetDate = DateTime.Today;
            }
            else
            {
                var reader = File.ReadAllLines(TransactionsPath);
                foreach (var item in reader)
                {
                    string[] itemsInFile = item.Split(" ");
                    if (int.Parse(itemsInFile[6]) == CardNumber && itemsInFile[0] == DateOnly.FromDateTime(DateTime.Now).ToString())
                    {
                        NumberOfTransactions++;
                    }
                }

            }
        }
        public void AnotherTransaction(out bool choosing)
        {
            choosing = true;
            var otherTransaction = false;
            while (!otherTransaction)
            {
                Console.WriteLine("Would you like to make another transaction?      (Y/N)");
                var moreTransactions = Console.ReadLine();
                if (string.IsNullOrEmpty(moreTransactions.Trim()))
                {
                    Console.WriteLine("Incorrect input, try again");
                    Console.ReadLine();
                }
                else if (moreTransactions.Trim().ToUpper() != "Y" && moreTransactions.Trim().ToUpper() != "N")
                {
                    Console.WriteLine("Incorrect input, try again");
                    Console.ReadLine();
                }
                if (moreTransactions.Trim().ToUpper() == "Y")
                {
                    otherTransaction = true;
                }
                else if (moreTransactions.Trim().ToUpper() == "N")
                {
                    Console.WriteLine("Please take your card, have a nice day!");
                    otherTransaction = true;
                    choosing = false;
                }
            }
        }
        public void LimitOfTransactionsReached(out bool isAmountIncorrect)
        {
            isAmountIncorrect = true;
            Console.Clear();
            if (NumberOfTransactions >= 10)
            {
                Console.WriteLine("You have reached your limit of transactions for today, come back again tomorrow!");
                Console.ReadLine();
                isAmountIncorrect = false; 
            }
        }
    }
}
