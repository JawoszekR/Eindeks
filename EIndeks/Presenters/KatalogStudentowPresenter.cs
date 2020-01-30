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
    class KatalogStudentowPresenter
    {
        IKatalogStudentowView _view;
        IUnitOfWork _uow;
        public KatalogStudentowPresenter(IKatalogStudentowView view)
        {
            _view = view;
            _uow = new EFUnitOfWork(new Model.ModelContext());
            _view.DataDoFiltr = DateTime.Today;
            _view.DataOdFiltr = DateTime.Today.AddYears(-100);
        }

        public void LoadData()
        {
            _view.Studenci = new BindingList<Student>(_uow.Studenci.GetAll().ToList());
        }

        public void ZapiszZmiany()
        {
            _uow.Studenci.AddRange(_view.Studenci.Where(s => s.Id == 0));
            _uow.Complite();
        }

        public void DeleteStudent(Student student)
        {
            _uow.Studenci.Remove(student);
        }

        public void FiltrujStudentow()
        {
            _view.Studenci = new BindingList<Student>(_uow.Studenci.Find(FiltrStudentow).ToList());
        }

        private bool FiltrStudentow(Student student)
        {
            bool imieOk = false;
            bool nazwiskoOk = false;
            bool nrIndeksuOk = false;
            bool dataUrodzeniaOk = false;
            imieOk = CheckImie(student);
            nazwiskoOk = CheckNazwisko(student);
            nrIndeksuOk = CheckNrIndeksu(student);
            dataUrodzeniaOk = CheckDataUrodzenia(student);
            return imieOk && nazwiskoOk && nrIndeksuOk && dataUrodzeniaOk;
        }

        private bool CheckDataUrodzenia(Student student)
        {
            return student.DataUrodzenia >= _view.DataOdFiltr && student.DataUrodzenia <= _view.DataDoFiltr;
        }

        private bool CheckNrIndeksu(Student student)
        {
            bool nrIndeksuOk;
            if (string.IsNullOrWhiteSpace(_view.NrIndeksuFiltr))
            {
                nrIndeksuOk = true;
            }
            else
            {
                nrIndeksuOk = student.NrIndeksu.ToString().Contains(_view.NrIndeksuFiltr.ToUpper());
            }

            return nrIndeksuOk;
        }

        private bool CheckNazwisko(Student student)
        {
            bool nazwiskoOk;
            if (string.IsNullOrWhiteSpace(_view.NazwiskoFiltr))
            {
                nazwiskoOk = true;
            }
            else
            {
                nazwiskoOk = student.Nazwisko.ToUpper().Contains(_view.NazwiskoFiltr.ToUpper());
            }

            return nazwiskoOk;
        }

        private bool CheckImie(Student student)
        {
            bool imieOk;
            if (string.IsNullOrWhiteSpace(_view.ImieFiltr))
            {
                imieOk = true;
            }
            else
            {
                imieOk = student.Imie.ToUpper().Contains(_view.ImieFiltr.ToUpper());
            }

            return imieOk;
        }
    }
}
