using Kartojimas_su_Laimonu.Entities.Interfaces;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Kartojimas_su_Laimonu.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        public int Save(T entity);
    }
}
