using System.Security.Cryptography.X509Certificates;

namespace projektas_2_bankomatas
{
    public class BankCard
    {                
        public decimal AccountBalance { get; protected set; }
        public int CardNumber { get; private set; }
        public string Password { get; private set; }
        

        public BankCard()
        {

        }
        public BankCard(int cardNumber, decimal accountBalance, string password)
        {
            AccountBalance = accountBalance;
            CardNumber = cardNumber;
            Password = password;
        }         
    }
}
    
