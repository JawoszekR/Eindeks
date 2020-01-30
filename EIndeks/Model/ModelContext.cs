using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=con")
        {

        }
        public DbSet<Student> Studenci { get; set; }
        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Ocena> Oceny { get; set; }
    }
}
