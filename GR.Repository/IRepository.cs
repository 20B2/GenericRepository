using System.Linq;

namespace GR.Repository
{
    public interface IRepository<T> where T:class
    {
        void Create(T entity);
        IQueryable<T> Read();
        void Update(T entity);
        void Delete(T entity);
    }
}
