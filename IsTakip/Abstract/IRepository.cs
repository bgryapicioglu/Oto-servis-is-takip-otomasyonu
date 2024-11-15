using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Abstract
{
    internal interface IRepository<T>
    {
        List<T> List();
        T GetById(int id);
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        void Save();

        IEnumerable<T> Get(Expression<Func<T, bool >> filter=null,
            Func<IQueryable<T>,
                IOrderedQueryable<T>> orderBy=null,
            string includeProperties="");

    }
}
