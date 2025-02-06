using Kartojimas_su_Laimonu.Entities;

namespace Kartojimas_su_Laimonu.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IDisposable
    {
        public OrderRepository(GenericDbContext context) : base(context)  { }
    }
}
