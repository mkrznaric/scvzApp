using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp.Forme_zaposlenici
{
    public partial class frmRaspored : Form
    {
        public frmRaspored()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DodajComboRaspored()
        {
            using (var db = new scvzAppEntities())
            {

                var upit = from m in db.mjesec
                           select m.naziv;
                cmbMjesec.DataSource = upit.ToList();
            }
        }

        public void PrikaziRaspored()
        {
            if (cmbMjesec.Text == "sijecanj")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 1
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;

                }
            }
            if (cmbMjesec.Text == "veljaca")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 2
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;

                }
            }
            if (cmbMjesec.Text == "ozujak")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 3
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
            if (cmbMjesec.Text == "travanj")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 4
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
            if (cmbMjesec.Text == "svibanj")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 5
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
            if (cmbMjesec.Text == "lipanj")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 6
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;

                }
            }
            if (cmbMjesec.Text == "srpanj")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 7
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
            if (cmbMjesec.Text == "kolovoz")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 8
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
            if (cmbMjesec.Text == "rujan")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 9
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
            if (cmbMjesec.Text == "listopad")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 10
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
            if (cmbMjesec.Text == "studeni")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 11
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
            if (cmbMjesec.Text == "prosinac")
            {
                using (var db = new scvzAppEntities())
                {

                    var upit = from s in db.smjena
                               where s.mjesecID == 12
                               select new { s.idsmjena, s.dan_u_mjesecu, s.vrsta_smjene, s.zaposlenik.ime, s.zaposlenik.prezime, s.zaposlenikID };

                    dgvRaspored.DataSource = upit.ToList();

                    dgvRaspored.Columns[0].Visible = false;
                    dgvRaspored.Columns[1].HeaderText = "Dan u mjesecu";
                    dgvRaspored.Columns[2].HeaderText = "Vrsta smjena";
                    dgvRaspored.Columns[3].HeaderText = "Ime recepcionera";
                    dgvRaspored.Columns[4].HeaderText = "Prezime recepcionera";
                    dgvRaspored.Columns[5].Visible = false;
                }
            }
        }

        private void frmRaspored_Load(object sender, EventArgs e)
        {
            DodajComboRaspored();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PrikaziRaspored();
        }

        private void btnIzbrisiZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvRaspored.CurrentRow != null)
            {

                using (var db = new scvzAppEntities())
                {
                    int id = int.Parse(dgvRaspored.CurrentRow.Cells[0].Value.ToString());
                    smjena smjena = new smjena() { idsmjena = id };
                    db.smjena.Attach(smjena);
                    db.smjena.Remove(smjena);
                    db.SaveChanges();
                }

                PrikaziRaspored();
            }
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            frmDodajSmjenu forma = new frmDodajSmjenu();
            forma.ShowDialog();
            PrikaziRaspored();
        }

        private void btnUrediZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvRaspored.CurrentRow != null)
            {
                smjena odabranaSmjena = new smjena();
                odabranaSmjena.idsmjena= int.Parse(dgvRaspored.CurrentRow.Cells[0].Value.ToString());
                odabranaSmjena.mjesecID = cmbMjesec.SelectedIndex + 1;
                odabranaSmjena.vrsta_smjene = dgvRaspored.CurrentRow.Cells[2].Value.ToString();
                odabranaSmjena.dan_u_mjesecu = int.Parse(dgvRaspored.CurrentRow.Cells[1].Value.ToString());
                odabranaSmjena.zaposlenikID = int.Parse(dgvRaspored.CurrentRow.Cells[5].Value.ToString());
                if (odabranaSmjena != null)
                {
                    frmUrediSmjenu forma = new frmUrediSmjenu(odabranaSmjena);
                    forma.ShowDialog();
                    PrikaziRaspored();
                }
            }
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmRaspored_Help forma = new Forme_help.frmRaspored_Help();
            forma.ShowDialog();
        }

        private void cmbMjesec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void dgvRaspored_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void btnPrikazi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void btnDodajZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void btnUrediZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void btnIzbrisiZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }
    }
}
