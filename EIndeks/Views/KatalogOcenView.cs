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
    public partial class KatalogOcenView : MetroFramework.Forms.MetroForm, IKatalogOcenView
    {
        public Student Student { get; set; }
        public BindingList<OcenaKatalogAdapter> Oceny
        {
            get { return grid_oceny.DataSource as BindingList<OcenaKatalogAdapter>; }
            set { grid_oceny.DataSource = value; }
        }

        public BindingList<Kurs> Kursy { 
            get {  return this.kursIdDataGridViewTextBoxColumn.DataSource as BindingList<Kurs>; }
            set { this.kursIdDataGridViewTextBoxColumn.DataSource = value; }
        }
        KatalogOcenPresenter _presenter;
        public KatalogOcenView(int studentId)
        {
            InitializeComponent();
            _presenter = new KatalogOcenPresenter(this);
            _presenter.LoadData(studentId);
        }

        private void btn_zapisz_Click(object sender, EventArgs e)
        {
            _presenter.ZapiszZmiany();
        }
    }
}
