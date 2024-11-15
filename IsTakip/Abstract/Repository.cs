using IsTakip.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Abstract
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _db = new DataContext();
        private DbSet<T>  _dbSet;

        public Repository()
        {
            _dbSet=_db.Set<T>();
        }

        public void Delete(T t)
        {
            _dbSet.Remove(t);
            Save();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {

            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T t)
        {
            _dbSet.Add(t);
            Save();
        }

        public List<T> List()
        {
            return _dbSet.ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(T t)
        {
            _dbSet.Attach(t);
            _db.Entry(t).State = EntityState.Modified;
            Save();
        }
    }
}
