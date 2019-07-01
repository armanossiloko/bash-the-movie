using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.WebAPI.Services
{
    public interface IDataService<T> //where T: class
    {
        IEnumerable<T> Get();
        T Get(int id);
    }
}
