namespace projektas_2_bankomatas
{
    public interface IMoneyOperations
    {
        public decimal RemoveMoney(decimal amount);
        public decimal AddMoney(decimal amount);
    }
}
