namespace projektas_2_bankomatas
{
    public class BankCard : IMoneyOperations
    {
       
        public decimal AccountBalance { get; private set; }
        public int CardNumber { get; private set; }
        public string Password { get; private set; }


        public BankCard( int cardNumber, decimal accountBalance, string password)
        {            
            AccountBalance = accountBalance;
            CardNumber = cardNumber;
            Password = password;
        }

        public decimal RemoveMoney(decimal amount)
        {
            var pathTransactions = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Transactions.txt";
            AccountBalance = AccountBalance - amount;
            using (StreamWriter sw = File.AppendText(pathTransactions))
            {
                sw.WriteLine($"Card with the number: {CardNumber} removed {amount} from the account");
            }           
            return AccountBalance;
        }

        public decimal AddMoney(decimal amount)
        {
            var pathTransactions = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Transactions.txt";
            AccountBalance = AccountBalance + amount;
            using(StreamWriter sw = File.AppendText(pathTransactions))
            {
                sw.WriteLine($"Card with the number: {CardNumber} added {amount} to the account");
            }
            return AccountBalance;
        }
    }
}
