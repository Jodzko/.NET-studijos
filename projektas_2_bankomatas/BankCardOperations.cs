namespace projektas_2_bankomatas
{
    public static class BankCardOperations
    {
        public static void RemoveMoney(BankCard card, decimal amount)
        {
            card.AccountBalance = card.AccountBalance - amount;
            using (StreamWriter sw = new StreamWriter(card.TransactionsPath, true))
            {
                sw.WriteLine($"{DateTime.Now.Date} Card with the number: {card.CardNumber} removed {amount} from the account");
            }
            card.NumberOfTransactions++;
        }
        public static void AddMoney(BankCard card, decimal amount)
        {
            card.AccountBalance = card.AccountBalance + amount;
            using (StreamWriter sw = new StreamWriter(card.TransactionsPath, true))
            {
                sw.WriteLine($"{DateTime.Now.Date} Card with the number: {card.CardNumber} added {amount} to the account");
            }
            card.NumberOfTransactions++;
        }
        public static void CheckAndResetTransactions(BankCard card)
        {
            if (DateTime.Today.Date > card.lastResetDate)
            {
                card.NumberOfTransactions = 0;
                card.lastResetDate = DateTime.Today;
            }
            else
            {
                var reader = File.ReadAllLines(card.TransactionsPath);
                foreach (var item in reader)
                {
                    string[] itemsInFile = item.Split(" ");
                    if (int.Parse(itemsInFile[6]) == card.CardNumber && itemsInFile[0] == DateOnly.FromDateTime(DateTime.Now).ToString())
                    {
                        card.NumberOfTransactions++;
                    }
                }

            }
        }
        public static void AnotherTransaction(out bool choosing)
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
        public static void LimitOfTransactionsReached(BankCard card, out bool isAmountIncorrect)
        {
            isAmountIncorrect = true;
            Console.Clear();
            if (card.NumberOfTransactions >= 10)
            {
                Console.WriteLine("You have reached your limit of transactions for today, come back again tomorrow!");
                Console.ReadLine();
                isAmountIncorrect = false;
            }
        }
    }
}
