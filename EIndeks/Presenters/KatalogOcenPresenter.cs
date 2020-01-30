using EIndeks.Model;
using EIndeks.Repository;
using EIndeks.Repository.EFRepository;
using EIndeks.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Presenters
{
    class KatalogOcenPresenter
    {
        IKatalogOcenView _view;
        IUnitOfWork _uow;
        public KatalogOcenPresenter(IKatalogOcenView view)
        {
            _view = view;
            _uow = new EFUnitOfWork(new Model.ModelContext());
        }

        public void LoadData(int studentId)
        {
            var student = _uow.Studenci.Get(studentId);
            _view.Student = student;
            var kursy = _uow.Kursy.GetAll().ToList();
            _view.Oceny = new BindingList<OcenaKatalogAdapter>(_uow.Oceny.Find(o => o.Student == student).Select(o => new OcenaKatalogAdapter(o)).ToList());
            _view.Kursy = new BindingList<Kurs>(_uow.Kursy.GetAll().ToList());
        }

        public void ZapiszZmiany()
        {
            var noweOceny = _view.Oceny.Where(s => s.Ocena.Id == 0);
            foreach (var ocena in noweOceny)
            {
                if (ocena.KursId.HasValue)
                {
                    ocena.Ocena.Student = _view.Student;
                    ocena.Ocena.Kurs = _uow.Kursy.Get(ocena.KursId.Value);
                    _uow.Oceny.Add(ocena.Ocena);
                }

            }
            _uow.Complite();
        }
    }
}
