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
    public partial class frmDodajZaposlenika : Form
    {
        public frmDodajZaposlenika()
        {
            InitializeComponent();
            this.ActiveControl = txtIme;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DodajCombo()
        {
            using (var db = new scvzAppEntities())
            {

                var upit = from t in db.tip_zaposlenika
                           select t.naziv;
                cmbTip.DataSource = upit.ToList();
            }
        }

        private void frmDodajZaposlenika_Load(object sender, EventArgs e)
        {
            DodajCombo();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new scvzAppEntities())
            {
                if (cmbTip.Text == "Administrator")
                {
                    zaposlenik Zaposlenik = new zaposlenik
                    {
                        ime = txtIme.Text,
                        prezime = txtPrezime.Text,
                        korisnicko_ime = txtKorisnickoIme.Text,
                        telefon = txtTelefon.Text,
                        email = txtEmail.Text,
                        lozinka = txtLozinka.Text,
                        zaposlenik_tip_zaposlenika = 1

                    };
                    db.zaposlenik.Add(Zaposlenik);
                    db.SaveChanges();
                }
                else if(cmbTip.Text == "Recepcioner")
                {
                    zaposlenik Zaposlenik = new zaposlenik
                    {
                        ime = txtIme.Text,
                        prezime = txtPrezime.Text,
                        korisnicko_ime = txtKorisnickoIme.Text,
                        telefon = txtTelefon.Text,
                        email = txtEmail.Text,
                        lozinka = txtLozinka.Text,
                        zaposlenik_tip_zaposlenika = 2

                    };
                    db.zaposlenik.Add(Zaposlenik);
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmDodajZaposlenika_Help forma = new Forme_help.frmDodajZaposlenika_Help();
            forma.ShowDialog();
        }

        private void frmDodajZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void txtIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void txtPrezime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void txtKorisnickoIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void txtTelefon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void cmbTip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void btnDodaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void btnOdustani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }
    }
}
