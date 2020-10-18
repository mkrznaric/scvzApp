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
    public partial class frmObracun : Form
    {
        public frmObracun()
        {
            InitializeComponent();
        }

        public void ComboMjesec()
        {
            using (var db = new scvzAppEntities())
            {

                var upit = from m in db.mjesec
                           select m.naziv;
                cmbMjesec.DataSource = upit.ToList();
            }
        }

        public void ComboZaposlenici()
        {
            using (var db = new scvzAppEntities())
            {

                var upit = from z in db.zaposlenik
                           select z.ime + " " + z.prezime;
                cmbZaposlenik.DataSource = upit.ToList();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmObracun_Load(object sender, EventArgs e)
        {
            ComboMjesec();
            ComboZaposlenici();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string[] ssize = cmbZaposlenik.Text.Split(null);
            var temp1 = ssize[0];
            var temp2 = ssize[1];
            var upit_pomocna = 0;
            var upit2_pomocna = 0;
            var mjesec = 0;

            if (cmbMjesec.Text == "sijecanj")
            {
                mjesec = 1;
            }
            if (cmbMjesec.Text == "veljaca")
            {
                mjesec = 2;
            }
            if (cmbMjesec.Text == "ozujak")
            {
                mjesec = 3;
            }
            if (cmbMjesec.Text == "travanj")
            {
                mjesec = 4;
            }
            if (cmbMjesec.Text == "svibanj")
            {
                mjesec = 5;
            }
            if (cmbMjesec.Text == "lipanj")
            {
                mjesec = 6;
            }
            if (cmbMjesec.Text == "srpanj")
            {
                mjesec = 7;
            }
            if (cmbMjesec.Text == "kolovoz")
            {
                mjesec = 8;
            }
            if (cmbMjesec.Text == "rujan")
            {
                mjesec = 9;
            }
            if (cmbMjesec.Text == "listopad")
            {
                mjesec = 10;
            }
            if (cmbMjesec.Text == "studeni")
            {
                mjesec = 11;
            }
            if (cmbMjesec.Text == "prosinac")
            {
                mjesec = 12;
            }

            using (var db = new scvzAppEntities())
            {
                var upit = from z in db.zaposlenik
                           where z.ime == temp1 && z.prezime == temp2
                           select z.idzaposlenik;
                upit_pomocna = upit.Max();

            }

            using (var db = new scvzAppEntities())
            {
                var upit = from s in db.smjena
                           where s.zaposlenikID == upit_pomocna && s.mjesecID==mjesec
                           select s.zaposlenikID;
                upit2_pomocna = upit.Count();
            }

            lblBrojSmjena.Text = upit2_pomocna.ToString();
            lblZaposlenik.Text = cmbZaposlenik.Text;
            lblMjesec.Text = cmbMjesec.Text;
            lblZarada.Text = (upit2_pomocna * 8 * 30).ToString();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmObracun_Help forma = new Forme_help.frmObracun_Help();
            forma.ShowDialog();
        }

        private void cmbZaposlenik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void cmbMjesec_KeyDown(object sender, KeyEventArgs e)
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

        private void btnOdustani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }
    }
}
