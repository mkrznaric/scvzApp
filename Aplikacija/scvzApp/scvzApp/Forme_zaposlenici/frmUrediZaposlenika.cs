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
    public partial class frmUrediZaposlenika : Form
    {
        private zaposlenik zaposlenikZaIzmjenu;

        public frmUrediZaposlenika(zaposlenik odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenikZaIzmjenu = odabraniZaposlenik;
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

        private void frmUrediZaposlenika_Load(object sender, EventArgs e)
        {
            DodajCombo();
            if (zaposlenikZaIzmjenu != null)
            {
                txtIme.Text = zaposlenikZaIzmjenu.ime.ToString();
                txtPrezime.Text = zaposlenikZaIzmjenu.prezime.ToString();
                txtKorisnickoIme.Text = zaposlenikZaIzmjenu.korisnicko_ime.ToString();
                txtTelefon.Text = zaposlenikZaIzmjenu.telefon.ToString();
                txtEmail.Text = zaposlenikZaIzmjenu.email.ToString();
                txtLozinka.Text = zaposlenikZaIzmjenu.lozinka.ToString();
                if (zaposlenikZaIzmjenu.zaposlenik_tip_zaposlenika == 1)
                {
                    cmbTip.Text = "Administrator";
                }
                else if (zaposlenikZaIzmjenu.zaposlenik_tip_zaposlenika == 2)
                {
                    cmbTip.Text = "Recepcioner";
                }
            }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            using (var db = new scvzAppEntities())
            {
                if (zaposlenikZaIzmjenu != null)
                {
                    db.zaposlenik.Attach(zaposlenikZaIzmjenu);
                    zaposlenikZaIzmjenu.ime = txtIme.Text;
                    zaposlenikZaIzmjenu.prezime = txtPrezime.Text;
                    zaposlenikZaIzmjenu.korisnicko_ime = txtKorisnickoIme.Text;
                    zaposlenikZaIzmjenu.telefon = txtTelefon.Text;
                    zaposlenikZaIzmjenu.email = txtEmail.Text;
                    zaposlenikZaIzmjenu.lozinka = txtLozinka.Text;
                    if (cmbTip.Text == "Administrator")
                    {
                        zaposlenikZaIzmjenu.zaposlenik_tip_zaposlenika = 1;
                    }
                    if (cmbTip.Text == "Recepcioner")
                    {
                        zaposlenikZaIzmjenu.zaposlenik_tip_zaposlenika = 2;
                    }

                    db.SaveChanges();
                }
            }
            Close();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmUrediZaposlenika_Help forma = new Forme_help.frmUrediZaposlenika_Help();
            forma.ShowDialog();
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

        private void btnIzmijeni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }
    }
}
