using EIndeks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Repository.EFRepository
{
    class EFUnitOfWork : IUnitOfWork
    {
        private readonly ModelContext _context;
        IStudentRepository _studenci;
        IKursRepository _kursy;
        IOcenaRepository _oceny;

        public IStudentRepository Studenci
        {
            get
            {
                return _studenci;
            }
        }
        public IKursRepository Kursy
        {
            get
            {
                return _kursy;
            }
        }
        public IOcenaRepository Oceny
        {
            get
            {
                return _oceny;
            }
        }
        public EFUnitOfWork(ModelContext context)
        {
            _context = context;
            _studenci = new EFStudentRepository(context);
            _kursy = new EFKursRepository(context);
            _oceny = new EFOcenaRepository(context);
        }

        public int Complite()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
