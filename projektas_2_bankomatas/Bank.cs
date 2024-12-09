namespace projektas_2_bankomatas
{
    public class Bank
    {
        public List<BankCard> ListOfCardsInBank { get; private set; } = new List<BankCard>();

        public Bank()
        {
            
        }
        public void AddCard(BankCard bankCard)
        {
            ListOfCardsInBank.Add(bankCard);
        }
    }
}
