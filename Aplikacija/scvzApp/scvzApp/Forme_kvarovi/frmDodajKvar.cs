using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp.Forme_kvarovi
{
    public partial class frmDodajKvar : Form
    {
        private int id;
        public frmDodajKvar(int broj)
        {
            id = broj;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodajKvar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekundarniDataSet.zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter1.Fill(this.sekundarniDataSet.zaposlenik);
            // TODO: This line of code loads data into the 'sekundarniDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.sekundarniDataSet.student);
            // TODO: This line of code loads data into the 'sekundarniDataSet.soba' table. You can move, or remove it, as needed.
            this.sobaTableAdapter2.Fill(this.sekundarniDataSet.soba);
            cmbStatus.SelectedIndex = 0;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void Dodaj()
        {
            using (var db = new scvzAppEntities())
            {
                kvar noviKvar = new kvar
                {
                    opis = txtOpis.Text,
                    datum_prijave = txtDatum.Value,
                    kvar_idsoba = int.Parse(cmbSoba.SelectedValue.ToString()),
                    kvar__prijavio_idstudent = int.Parse(cmbKvarPrijavio.SelectedValue.ToString()),
                    kvar_zaprimio_idzaposlenik = id,
                    status_kvara = cmbStatus.SelectedItem.ToString()
                };
                db.kvar.Add(noviKvar);
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno dodan novi kvar!");
            Close();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmDodajKvar_Help forma = new Forme_help.frmDodajKvar_Help();
            forma.ShowDialog();
        }
    }
}
