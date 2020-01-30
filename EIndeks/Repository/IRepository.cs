using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);

        void Add(T item);
        void AddRange(IEnumerable<T> items);

        void Remove(T item);
        void RemoveRange(IEnumerable<T> items);
    }
}
