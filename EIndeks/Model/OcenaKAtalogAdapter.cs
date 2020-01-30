using EIndeks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Model
{
    public class OcenaKatalogAdapter
    {
        Ocena _ocena;
        public Ocena Ocena { get { return _ocena; } }
        public int Value { get { return _ocena.Value; } set { _ocena.Value = value; } }
        public int? KursId { get; set; }
        public OcenaKatalogAdapter(Ocena ocena)
        {
            _ocena = ocena;
            if(ocena.Kurs != null)
                KursId = ocena.Kurs.Id;
        }
        public OcenaKatalogAdapter() : this(new Ocena())
        {

        }
    }
}
