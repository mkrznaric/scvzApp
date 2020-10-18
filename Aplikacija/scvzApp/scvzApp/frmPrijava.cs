using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private int DohvatiID(string korime)
        {
            int id = 0;
            IEnumerable<int> broj;
            List<int> b;
            using (var db = new scvzAppEntities())
                {
                broj = from i in db.zaposlenik
                       where i.korisnicko_ime == korime
                       select i.idzaposlenik;

                b = broj.ToList();
            }
            id = b[0];
            return id;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            using (var db = new scvzAppEntities())
            {
                var upit = from z in db.zaposlenik
                           where z.korisnicko_ime == txtKorime.Text && z.lozinka == txtLozinka.Text
                           select z.zaposlenik_tip_zaposlenika;

                if (upit.Any())
                {
                    if (upit.First() == 1)
                    {
                        this.Hide();
                        MessageBox.Show("Uspješno ste se prijavili kao " + txtKorime.Text + "!", "Uspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1_Admin form = new Form1_Admin(DohvatiID(txtKorime.Text));
                        form.ShowDialog();
                    }

                    else if (upit.First() == 2)
                    {
                        this.Hide();
                        MessageBox.Show("Uspješno ste se prijavili kao " + txtKorime.Text + "!", "Uspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 form = new Form1(DohvatiID(txtKorime.Text));
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Netočni korisničko ime ili lozinka!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLozinka.Clear();
                }

                

            }


        }

        private void txtKorime_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnPrijava_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrijava_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmPrijava_Help forma = new Forme_help.frmPrijava_Help();
            forma.ShowDialog();
        }

        private void frmPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }
    }
}
