namespace projektas_2_bankomatas
{
    public class Methods
    {
        public void Menu()
        {
            var choice = 0;
            var choosing = true;
            var transactionsToday = 0;
            while (choosing)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Show balance of the account");
                Console.WriteLine("2. Show 5 last transactions");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("3. Withdraw money");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

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
