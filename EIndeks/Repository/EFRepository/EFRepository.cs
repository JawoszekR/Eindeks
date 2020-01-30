using EIndeks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Repository.EFRepository
{
    class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly ModelContext _context;
        public EFRepository(ModelContext context)
        {
            _context = context;
        }
        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            _context.Set<T>().AddRange(items);
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public T Get(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Remove(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public void RemoveRange(IEnumerable<T> items)
        {
            _context.Set<T>().RemoveRange(items);
        }
    }
}
