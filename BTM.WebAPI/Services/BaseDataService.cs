using BTM.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.WebAPI.Services
{
    public class BaseDataService<T> : IDataService<T> where T: class
    {
        private readonly ApplicationDbContext _context;
        private Microsoft.EntityFrameworkCore.DbSet<T> entities;
        public BaseDataService(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        public IEnumerable<T> Get()
        {
            return entities.AsNoTracking().AsEnumerable();
        }

        public T Get(int id)
        {
            return entities.Find(id);
        }
    }
}
