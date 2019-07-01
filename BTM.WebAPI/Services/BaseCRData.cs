using BTM.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BTM.WebAPI.Services
{
    public class BaseCRData<T> : ICRData<T> where T : class
    {
        private ApplicationDbContext _context;
        private Microsoft.EntityFrameworkCore.DbSet<T> entities;

        public BaseCRData(ApplicationDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public T Add(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Entity");
            }
            var entity = _context.Add(obj);
            _context.SaveChanges();
            return entity.Entity;
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return entities.FirstOrDefault(predicate);
        }

        public IEnumerable<T> Get()
        {
            return entities.AsNoTracking().AsEnumerable<T>();
        }
    }
}
