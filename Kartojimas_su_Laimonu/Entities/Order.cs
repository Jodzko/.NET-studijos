using Kartojimas_su_Laimonu.Entities.Interfaces;

namespace Kartojimas_su_Laimonu.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public Guid Number { get; set; }
        public string ShippingAdress { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateCreated { get; set; }
        List<OrderItem> OrderItems { get; set; }
    }
}
