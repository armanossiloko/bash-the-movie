using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.WebAPI.Services
{
    public interface IData<T> : IDataService<T> //where T: class
    {
        T Add(T obj);

        T Get(/*int id, */System.Linq.Expressions.Expression<Func<T, bool>> predicate);

        // Possibly obsolete
        IQueryable<T> GetByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression);
        T Update(T obj);
        // Possibly obsolete
        T Update(int id, T entity);
        T Delete(T entity);
        T Delete(int id);
    }
}
