namespace _6_paskaita_testing.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<int> BookIds { get; set; } = new List<int>();
        public decimal TotalAmount { get; set; }
        public bool IsPaid { get; set; }
    }
}
