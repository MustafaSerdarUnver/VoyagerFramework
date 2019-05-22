using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Voyage.DAL
{
    public interface IRepo<T>
    {
        T GetById(int Id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IList<T> GetAll();
        T Add(T item);
        void Update(T item);
        void Remove(T item);
    }
}
