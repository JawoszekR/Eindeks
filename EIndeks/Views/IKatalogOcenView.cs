using System.ComponentModel;
using EIndeks.Model;

namespace EIndeks.Views
{
    public interface IKatalogOcenView
    {
        Student Student { get; set; }
        BindingList<OcenaKatalogAdapter> Oceny { get; set; }
        BindingList<Kurs> Kursy { get; set; }
    }
}