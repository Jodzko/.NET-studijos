using System.Security.Cryptography.X509Certificates;

namespace projektas_2_bankomatas
{
    public class BankCard
    {                
        public decimal AccountBalance { get; internal set; }
        public int CardNumber { get; private set; }
        internal string PasswordHashed { get; private set; }
        public string StoredSalt { get; private set; }
        internal int NumberOfTransactions = 0;
        internal readonly string TransactionsPath = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Transactions.txt";
        internal DateTime lastResetDate = DateTime.Now.Date;


        public BankCard()
        {

        }
        public BankCard(int cardNumber, decimal accountBalance, string password, string salt)
        {
            AccountBalance = accountBalance;
            CardNumber = cardNumber;
            PasswordHashed = password;
            StoredSalt = salt;
        }         
    }
}
    
