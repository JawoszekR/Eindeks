using EIndeks.Model;
using EIndeks.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIndeks.Views
{
    public partial class KatalogStudentowView : MetroFramework.Forms.MetroForm, IKatalogStudentowView
    {
        KatalogStudentowPresenter _presenter;
        public BindingList<Student> Studenci { get { return grid_studenci.DataSource as BindingList<Student>; } set { grid_studenci.DataSource = value; } }
        public string ImieFiltr { get { return this.metroTextBox_imie.Text; } set { this.metroTextBox_imie.Text = value; } }
        public string NazwiskoFiltr { get { return this.metroTextBox_nazwisko.Text; } set { this.metroTextBox_nazwisko.Text = value; } }
        public string NrIndeksuFiltr { get { return this.metroTextBox_nrIndeksu.Text; } set { this.metroTextBox_nrIndeksu.Text = value; } }

        public DateTime DataOdFiltr { get { return this.metroDateTime_od.Value; } set { this.metroDateTime_od.Value = value; } }
        public DateTime DataDoFiltr { get { return this.metroDateTime_do.Value; } set { this.metroDateTime_do.Value = value; } }

        public KatalogStudentowView()
        {
            InitializeComponent();
            _presenter = new KatalogStudentowPresenter(this);
            _presenter.LoadData();
        }

        private void btn_zapisz_Click(object sender, EventArgs e)
        {
            _presenter.ZapiszZmiany();
        }

        private void grid_studenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && grid_studenci.Columns[e.ColumnIndex] == colOceny)
            {
                var row = grid_studenci.Rows[e.RowIndex];
                var student = row.DataBoundItem as Student;
                if (student == null)
                    return;
                var formOceny = new KatalogOcenView(student.Id);
                formOceny.Show();
            }
        }

        private void metroTextBox_imie_TextChanged(object sender, EventArgs e)
        {
            if (_presenter != null)
                _presenter.FiltrujStudentow();
        }

        private void metroDateTime_do_ValueChanged(object sender, EventArgs e)
        {
            if (_presenter != null)
                _presenter.FiltrujStudentow();
        }

        private void grid_studenci_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var student = e.Row.DataBoundItem as Student;
            if(student != null)
            {
                _presenter.DeleteStudent(student);
            }
        }
    }
}
