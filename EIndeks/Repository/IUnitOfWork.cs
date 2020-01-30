using EIndeks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Repository
{
    public interface IUnitOfWork
    {
        IStudentRepository Studenci { get; }
        IKursRepository Kursy { get; }
        IOcenaRepository Oceny { get; }
        int Complite();
    }
}
