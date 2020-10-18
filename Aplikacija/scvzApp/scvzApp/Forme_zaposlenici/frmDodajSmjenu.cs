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
    public partial class frmDodajSmjenu : Form
    {
        public frmDodajSmjenu()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void ComboVrstaSmjene()
        {
            List<string> listaVrstaSmjena = new List<string>();
            listaVrstaSmjena.Add("Jutarnja");
            listaVrstaSmjena.Add("Popodnevna");
            listaVrstaSmjena.Add("Nocna");

            cmbVrstaSmjene.DataSource = listaVrstaSmjena;
        }

        public void ComboZaposlenici()
        {
            using (var db = new scvzAppEntities())
            {

                var upit = from z in db.zaposlenik
                           select z.ime+" "+z.prezime;
                cmbZaposlenik.DataSource = upit.ToList();
            }
        }

        private void frmDodajSmjenu_Load(object sender, EventArgs e)
        {
            ComboZaposlenici();
            ComboMjesec();
            ComboVrstaSmjene();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string[] ssize = cmbZaposlenik.Text.Split(null);
            var temp1 = ssize[0];
            var temp2 = ssize[1];
            var upit_pomocna = 0;

            using(var db = new scvzAppEntities())
            {
                var upit = from z in db.zaposlenik
                           where z.ime == temp1 && z.prezime == temp2
                           select z.idzaposlenik;
                upit_pomocna = upit.Max();

            }
            using (var dba = new scvzAppEntities())
            {
                smjena smjena = new smjena
                {
                    vrsta_smjene = cmbVrstaSmjene.Text,
                    dan_u_mjesecu = int.Parse(txtDanUMjesecu.Text),
                    mjesecID = cmbMjesec.SelectedIndex + 1,
                    zaposlenikID = upit_pomocna
                };
                dba.smjena.Add(smjena);
                dba.SaveChanges();
            }
            Close();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmDodajSmjenu_Help forma = new Forme_help.frmDodajSmjenu_Help();
            forma.ShowDialog();
        }

        private void cmbMjesec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void txtDanUMjesecu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void cmbVrstaSmjene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void cmbZaposlenik_KeyDown(object sender, KeyEventArgs e)
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
