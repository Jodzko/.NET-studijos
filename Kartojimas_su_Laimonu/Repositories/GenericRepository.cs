using Kartojimas_su_Laimonu.Entities;
using Kartojimas_su_Laimonu.Entities.Interfaces;
using Kartojimas_su_Laimonu.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kartojimas_su_Laimonu.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly GenericDbContext _dbContext;
        private readonly DbSet<T> _db_Set;

        public GenericRepository(GenericDbContext dbContext)
        {
            _dbContext = dbContext;
            _db_Set = dbContext.Set<T>();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _db_Set.Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _db_Set.AsEnumerable();
        }

        public T GetById(int id)
        {
            return _db_Set.Find(id);
        }

        public int Save(T entity)
        {
            if(entity.Id == 0)
            {
                _db_Set.Add(entity);
            }
            else
            {
                _db_Set.Update(entity);
            }
            _dbContext.SaveChanges();
            return entity.Id;
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
