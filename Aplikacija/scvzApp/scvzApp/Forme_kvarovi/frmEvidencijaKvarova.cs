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
    public partial class frmEvidencijaKvarova : Form
    {
        private int id;
        public frmEvidencijaKvarova(int broj)
        {
            InitializeComponent();
            PrikaziKvarove();
            id = broj;
        }

        private void PrikaziKvarove()
        {
            BindingList<kvar> kvarovi;
            using (var db = new scvzAppEntities())
            {
                kvarovi = new BindingList<kvar>(db.kvar.ToList());
            }
            kvarBindingSource4.DataSource = kvarovi;
        }
        
        private void btnDodajKvar_Click(object sender, EventArgs e)
        {
            frmDodajKvar forma = new frmDodajKvar(id);
            forma.ShowDialog();
            PrikaziKvarove();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Izbrisi();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            Uredi();
        }

        private void frmEvidencijaKvarova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekundarniDataSet.kvar' table. You can move, or remove it, as needed.
            this.kvarTableAdapter1.Fill(this.sekundarniDataSet.kvar);
            // TODO: This line of code loads data into the 'sekundarniDataSet.soba' table. You can move, or remove it, as needed.
            this.sobaTableAdapter1.Fill(this.sekundarniDataSet.soba);
            // TODO: This line of code loads data into the 'primarni_DataSet.zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.primarni_DataSet.zaposlenik);
            // TODO: This line of code loads data into the 'primarni_DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.primarni_DataSet.student);

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Uredi()
        {
            if (dgvKvarovi.CurrentRow != null)
            {
                kvar odabraniKvar = dgvKvarovi.CurrentRow.DataBoundItem as kvar;
                if (odabraniKvar != null)
                {
                    frmUrediKvar forma = new frmUrediKvar(odabraniKvar, id);
                    forma.ShowDialog();
                    PrikaziKvarove();
                }
            }
        }

        private void Izbrisi()
        {
            if (dgvKvarovi.CurrentRow != null)
            {
                kvar odabraniKvar = dgvKvarovi.CurrentRow.DataBoundItem as kvar;
                if (odabraniKvar != null)
                {
                    if (MessageBox.Show("Sigrno želite izbrisati kvar?", "Upozorenje", MessageBoxButtons.YesNo)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new scvzAppEntities())
                        {
                            db.kvar.Attach(odabraniKvar);
                            db.kvar.Remove(odabraniKvar);
                            db.SaveChanges();
                        }
                        PrikaziKvarove();
                    }
                }
            }
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmEvidencijaKvarova_Help forma = new Forme_help.frmEvidencijaKvarova_Help();
            forma.ShowDialog();
        }
    }
}
