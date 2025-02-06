using Kartojimas_su_Laimonu.Entities;
using Kartojimas_su_Laimonu.Entities.Interfaces;

namespace Kartojimas_su_Laimonu.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IDisposable
    {
        private readonly GenericDbContext _dbContext;
        public StudentRepository(GenericDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }



    }
}
