using EIndeks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Repository.EFRepository
{
    class EFKursRepository : EFRepository<Kurs>, IKursRepository
    {
        public EFKursRepository(ModelContext context) : base(context)
        {

        }
    }
}
