using System;
using System.ComponentModel;
using EIndeks.Model;

namespace EIndeks.Views
{
    public interface IKatalogStudentowView
    {
        BindingList<Student> Studenci { get; set; }
        string ImieFiltr { get; set; }
        string NazwiskoFiltr { get; set; }
        string NrIndeksuFiltr { get; set; }
        DateTime DataOdFiltr { get; set; }
        DateTime DataDoFiltr { get; set; }
    }
}