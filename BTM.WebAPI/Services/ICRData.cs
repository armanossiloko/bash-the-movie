using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.WebAPI.Services
{
    public interface ICRData<T>
    {
        T Add(T obj);
        IEnumerable<T> Get();
        T Get(/*int id, */System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }
}
