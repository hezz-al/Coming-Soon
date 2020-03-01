using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MainSite.AppCode.Infrastructure
{
    public interface IRepository<T>
        where T : class
    {
        T Add(T entity);
        T Edit(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
