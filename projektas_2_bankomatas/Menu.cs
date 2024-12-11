namespace projektas_2_bankomatas
{
    public static class Menu
    {
                        
        public static void OpenMenu(BankCard card)
        {

            BankCardOperations.CheckAndResetTransactions(card);
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
                        BankCardOperations.AnotherTransaction(out choosing);
                        break;
                    case 2:
                        var transactionDisplayCount = 0;
                        var display = File.ReadAllLines(card.TransactionsPath);
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
                                    BankCardOperations.AnotherTransaction(out choosing);
                                }
                            }
                        }
                        if (transactionDisplayCount != 5)
                        {
                            BankCardOperations.AnotherTransaction(out choosing);
                        }
                        break;
                    case 3:
                        isAmountIncorrect = true;
                        while (isAmountIncorrect)
                        {
                            BankCardOperations.LimitOfTransactionsReached(card, out isAmountIncorrect);
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
                            if (card.NumberOfTransactions < 10)
                            {
                                BankCardOperations.RemoveMoney(card, input);
                                Console.WriteLine($"Transaction complete! Please take your {input} Euros.");
                                BankCardOperations.AnotherTransaction(out choosing);
                                isAmountIncorrect = false;
                            }
                        }
                        break;
                    case 4:
                        isAmountIncorrect = true;
                        while (isAmountIncorrect)
                        {
                            BankCardOperations.LimitOfTransactionsReached(card, out isAmountIncorrect);
                            Console.WriteLine("Enter the amount you want to Add: ");
                            if (!int.TryParse(Console.ReadLine(), out int input))
                            {
                                continue;
                            }
                            if (card.NumberOfTransactions < 10)
                            {
                                BankCardOperations.AddMoney(card, input);
                                Console.WriteLine($"Transaction complete! Added {input} Euros to your account.");
                                BankCardOperations.AnotherTransaction(out choosing);
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
    }
}

