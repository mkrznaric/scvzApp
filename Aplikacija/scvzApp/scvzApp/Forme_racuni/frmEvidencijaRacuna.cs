using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp.Forme_racuni
{
    public partial class frmEvidencijaRacuna : Form
    {
        private int id;
        public frmEvidencijaRacuna(int broj)
        {
            InitializeComponent();
            id = broj;
            PrikaziRacune();
        }

        private void PrikaziRacune()
        {
            BindingList<racun> racuni;
            using (var db = new scvzAppEntities())
            {
                racuni = new BindingList<racun>(db.racun.ToList());
            }
            racunBindingSource.DataSource = racuni;
        }
        private void IzbrisiRacun()
        {
            if (dgvRacuni.CurrentRow != null)
            {
                racun odabraniRacun = dgvRacuni.CurrentRow.DataBoundItem as racun;
                if (odabraniRacun != null)
                {
                    if (MessageBox.Show("Sigrno želite izbrisati račun?", "Upozoenje", MessageBoxButtons.YesNo)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new scvzAppEntities())
                        {
                            db.racun.Attach(odabraniRacun);
                            db.racun.Remove(odabraniRacun);
                            db.SaveChanges();
                        }
                        PrikaziRacune();
                    }
                }
            }
        }
        private void KreirajNoviRacun()
        {
            racun noviRacun = new racun();
            using (var db = new scvzAppEntities())
            {
                noviRacun.datum_vrijeme_racuna = DateTime.Now.ToString();
                noviRacun.zaposlenik_idzaposlenik = id;
                db.racun.Add(noviRacun);
                db.SaveChanges();
            }
            frmDodajRacun forma = new frmDodajRacun(noviRacun);
            forma.ShowDialog();
            PrikaziRacune();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEvidencijaRacuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primarni_DataSet.zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.primarni_DataSet.zaposlenik);
            // TODO: This line of code loads data into the 'primarni_DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.primarni_DataSet.student);
            // TODO: This line of code loads data into the 'primarni_DataSet.racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.primarni_DataSet.racun);

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            IzbrisiRacun();
        }

        private void btnDodajRacun_Click(object sender, EventArgs e)
        {
            this.Hide();
            KreirajNoviRacun();
            this.Show();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmEvidencijaRacuna_Help forma = new Forme_help.frmEvidencijaRacuna_Help();
            forma.ShowDialog();
        }
    }
}
