﻿using EIndeks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Repository.EFRepository
{
    class EFStudentRepository : EFRepository<Student> , IStudentRepository
    {
        public EFStudentRepository(ModelContext context) : base(context)
        {

        }
    }
}
