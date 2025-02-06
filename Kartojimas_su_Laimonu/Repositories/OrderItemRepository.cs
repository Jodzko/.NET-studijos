using Kartojimas_su_Laimonu.Entities;

namespace Kartojimas_su_Laimonu.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IDisposable
    {
        public OrderItemRepository(GenericDbContext dbContext) : base(dbContext)   { }
    }
}
