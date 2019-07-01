using BTM.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.WebAPI.Services
{
    public class BaseData<T> : IData<T> where T: class
    {
        private readonly ApplicationDbContext _context;
        private Microsoft.EntityFrameworkCore.DbSet<T> entities;

        public BaseData(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        public T Add(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Entity");
            }
            var x = entities.Add(obj);
            _context.SaveChanges();
            return x.Entity;
        }

        public IEnumerable<T> Get()
        {
            return entities.AsNoTracking().AsEnumerable();
        }

        public T Get(int id)
        {
            var entity = entities.Find(id);
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public T Get(/*int id, */System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return entities.AsNoTracking().FirstOrDefault(predicate);
        }

        // Possibly obsolete
        public IQueryable<T> GetByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return entities.AsNoTracking().Where(expression);
        }


        public T Update(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Entity");
            }

            _context.Attach(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

        // Possibly obsolete
        public T Update(int id, T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Delete(int id)
        {
            var obj = Get(id);
            entities.Remove(obj);
            _context.SaveChanges();
            return obj;
        }

        //public T Delete(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        //{
        //    var entityToDelete = _context.Set<T>().FirstOrDefault(expression);
        //    if (entityToDelete != null)
        //    {
        //        _context.Set<T>().Remove(entityToDelete);
        //    }
        //    return entityToDelete;
        //}

        //public virtual T Update(int id, TUpdate request)
        //{
        //    var entity = _context.Set<TDatabase>().Find(id);
        //    _context.Set<TDatabase>().Attach(entity);
        //    _context.Set<TDatabase>().Update(entity);

        //    _mapper.Map(request, entity);

        //    _context.SaveChanges();

        //    return _mapper.Map<TModel>(entity);
        //}
    }
}
