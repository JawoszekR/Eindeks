﻿using EIndeks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Repository.EFRepository
{
    class EFOcenaRepository : EFRepository<Ocena>, IOcenaRepository
    {
        public EFOcenaRepository(ModelContext context) : base(context)
        {
            
        }
    }
}