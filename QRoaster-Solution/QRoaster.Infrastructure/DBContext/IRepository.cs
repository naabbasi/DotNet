using System.Linq.Expressions;

namespace QRoaster.Infrastructure.DBContext
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        Task<IList<T>> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
