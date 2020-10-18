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
    public partial class frmUrediStudenta : Form
    {
        private student studentZaIzmjenu;

        public frmUrediStudenta(student odabraniStudent)
        {
            InitializeComponent();
            studentZaIzmjenu = odabraniStudent;
            UpisiPodatkeOStudentu();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpisiPodatkeOStudentu()
        {
            txtIme.Text = studentZaIzmjenu.ime;
            txtPrezime.Text = studentZaIzmjenu.prezime;
            txtAdresa.Text = studentZaIzmjenu.adresa;
        }
        private void frmUrediStudenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ternarniDataSet.zupanija' table. You can move, or remove it, as needed.
            this.zupanijaTableAdapter1.Fill(this.ternarniDataSet.zupanija);
            // TODO: This line of code loads data into the 'ternarniDataSet.fakultet' table. You can move, or remove it, as needed.
            this.fakultetTableAdapter.Fill(this.ternarniDataSet.fakultet);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SpremiIzmjene();
        }

        private void SpremiIzmjene()
        {
            using (var db = new scvzAppEntities())
            {
                if (studentZaIzmjenu != null)
                {
                    db.student.Attach(studentZaIzmjenu);
                    studentZaIzmjenu.ime = txtIme.Text;
                    studentZaIzmjenu.prezime = txtPrezime.Text;
                    studentZaIzmjenu.adresa = txtAdresa.Text;
                    studentZaIzmjenu.datum_rodjenja = txtDatumRodjenja.Value;
                    studentZaIzmjenu.spol = cmbSpol.Text;
                    studentZaIzmjenu.zupanija = int.Parse(cmbZupanija.SelectedValue.ToString());
                    studentZaIzmjenu.fakultet = int.Parse(cmbFakultet.SelectedValue.ToString());
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmUrediStudenta_Help forma = new Forme_help.frmUrediStudenta_Help();
            forma.ShowDialog();
        }
    }
}
