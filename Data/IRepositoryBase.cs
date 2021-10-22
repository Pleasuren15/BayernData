using System;
using System.Linq;
using System.Linq.Expressions;

namespace BayernData.Data
{
    public interface IRepositoryBase<T>
    {
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IQueryable<T> FindAll();
        T FindById(int id);
    }
}
