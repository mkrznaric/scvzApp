using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp.Forme_studenti
{
    public partial class frmDodajStudenta : Form
    {
        public frmDodajStudenta()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajNovogStudenta();
        }

        private void frmDodajStudenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ternarniDataSet.fakultet' table. You can move, or remove it, as needed.
            this.fakultetTableAdapter.Fill(this.ternarniDataSet.fakultet);
            // TODO: This line of code loads data into the 'ternarniDataSet.zupanija' table. You can move, or remove it, as needed.
            this.zupanijaTableAdapter1.Fill(this.ternarniDataSet.zupanija);
            // TODO: This line of code loads data into the '_19026_DBDataSet.zupanija' table. You can move, or remove it, as needed.
            this.zupanijaTableAdapter.Fill(this._19026_DBDataSet.zupanija);
        }

        private void DodajNovogStudenta()
        {
            using (var db = new scvzAppEntities())
            {
                student noviStudent = new student
                {
                    ime = txtIme.Text,
                    prezime = txtPrezime.Text,
                    adresa = txtAdresa.Text,
                    zupanija = int.Parse(cmbZupanija.SelectedValue.ToString()),
                    spol = cmbSpol.Text,
                    datum_rodjenja = txtDatumRodjenja.Value,
                    fakultet = int.Parse(cmbFakultet.SelectedValue.ToString())
                };
                db.student.Add(noviStudent);
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno dodan novi student");
            Close();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmDodajStudenta_Help forma = new Forme_help.frmDodajStudenta_Help();
            forma.ShowDialog();
        }
    }
}
