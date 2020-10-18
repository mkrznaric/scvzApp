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
    public partial class frmUrediSmjenu : Form
    {
        private smjena smjenaZaIzmjenu;

        public frmUrediSmjenu(smjena odabranaSmjena)
        {
            InitializeComponent();
            smjenaZaIzmjenu = odabranaSmjena;
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
                           select z.ime + " " + z.prezime;
                cmbZaposlenik.DataSource = upit.ToList();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUrediSmjenu_Load(object sender, EventArgs e)
        {
            ComboMjesec();
            ComboVrstaSmjene();
            ComboZaposlenici();


            if (smjenaZaIzmjenu != null)
            {
                int pomocna = int.Parse(smjenaZaIzmjenu.mjesecID.ToString());
                if(pomocna == 1)
                {
                    cmbMjesec.Text = "sijecanj";
                }
                if (pomocna == 2)
                {
                    cmbMjesec.Text = "veljaca";
                }
                if (pomocna == 3)
                {
                    cmbMjesec.Text = "ozujak";
                }
                if (pomocna == 4)
                {
                    cmbMjesec.Text = "travanj";
                }
                if (pomocna == 5)
                {
                    cmbMjesec.Text = "svibanj";
                }
                if (pomocna == 6)
                {
                    cmbMjesec.Text = "lipanj";
                }
                if (pomocna == 7)
                {
                    cmbMjesec.Text = "srpanj";
                }
                if (pomocna == 8)
                {
                    cmbMjesec.Text = "kolovoz";
                }
                if (pomocna == 9)
                {
                    cmbMjesec.Text = "rujan";
                }
                if (pomocna == 10)
                {
                    cmbMjesec.Text = "listopad";
                }
                if (pomocna == 11)
                {
                    cmbMjesec.Text = "studeni";
                }
                if (pomocna == 12)
                {
                    cmbMjesec.Text = "prosinac";
                }
                txtDanUMjesecu.Text = smjenaZaIzmjenu.dan_u_mjesecu.ToString();
                cmbVrstaSmjene.Text = smjenaZaIzmjenu.vrsta_smjene;

                var pomocna_idzaposlenik= int.Parse(smjenaZaIzmjenu.zaposlenikID.ToString());

                using (var db = new scvzAppEntities())
                {

                    var upit = from z in db.zaposlenik
                               where z.idzaposlenik == pomocna_idzaposlenik
                               select z.ime+" "+z.prezime;
                    List<string> pomocna_lista = upit.ToList();

                    cmbZaposlenik.Text = pomocna_lista[0];
                }

                
            }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            string[] ssize = cmbZaposlenik.Text.Split(null);
            var temp1 = ssize[0];
            var temp2 = ssize[1];
            var upit_pomocna = 0;

            using (var db = new scvzAppEntities())
            {
                var upit = from z in db.zaposlenik
                           where z.ime == temp1 && z.prezime == temp2
                           select z.idzaposlenik;
                upit_pomocna = upit.Max();

            }

            using (var db = new scvzAppEntities())
            {
                if (smjenaZaIzmjenu != null)
                {
                    db.smjena.Attach(smjenaZaIzmjenu);

                    if (cmbMjesec.Text == "sijecanj")
                    {
                        smjenaZaIzmjenu.mjesecID = 1;
                    }
                    if (cmbMjesec.Text == "veljaca")
                    {
                        smjenaZaIzmjenu.mjesecID = 2;
                    }
                    if (cmbMjesec.Text == "ozujak")
                    {
                        smjenaZaIzmjenu.mjesecID = 3;
                    }
                    if (cmbMjesec.Text == "travanj")
                    {
                        smjenaZaIzmjenu.mjesecID = 4;
                    }
                    if (cmbMjesec.Text == "svibanj")
                    {
                        smjenaZaIzmjenu.mjesecID = 5;
                    }
                    if (cmbMjesec.Text == "lipanj")
                    {
                        smjenaZaIzmjenu.mjesecID = 6;
                    }
                    if (cmbMjesec.Text == "srpanj")
                    {
                        smjenaZaIzmjenu.mjesecID = 7;
                    }
                    if (cmbMjesec.Text == "kolovoz")
                    {
                        smjenaZaIzmjenu.mjesecID = 8;
                    }
                    if (cmbMjesec.Text == "rujan")
                    {
                        smjenaZaIzmjenu.mjesecID = 9;
                    }
                    if (cmbMjesec.Text == "listopad")
                    {
                        smjenaZaIzmjenu.mjesecID = 10;
                    }
                    if (cmbMjesec.Text == "studeni")
                    {
                        smjenaZaIzmjenu.mjesecID = 11;
                    }
                    if (cmbMjesec.Text == "prosinac")
                    {
                        smjenaZaIzmjenu.mjesecID = 12;
                    }

                    smjenaZaIzmjenu.dan_u_mjesecu = int.Parse(txtDanUMjesecu.Text);
                    smjenaZaIzmjenu.vrsta_smjene = cmbVrstaSmjene.Text;
                    smjenaZaIzmjenu.zaposlenikID = upit_pomocna;
                    smjenaZaIzmjenu.idsmjena = 
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmUrediSmjenu_Help forma = new Forme_help.frmUrediSmjenu_Help();
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

        private void btnIzmijeni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }
    }
}
