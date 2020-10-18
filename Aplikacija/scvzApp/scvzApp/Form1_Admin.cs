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
    public partial class Form1_Admin : Form
    {
        private int id;

        public Form1_Admin(int broj)
        {
            InitializeComponent();
            id = broj;
        }

        private void pretražiSobeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEvidencijaSoba form = new frmEvidencijaSoba();
            form.ShowDialog();
        }

        private void spolToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStatistikaStudentiSpol form = new frmStatistikaStudentiSpol();
            form.ShowDialog();
        }

        private void županijaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStatistikaZupanije forma = new frmStatistikaZupanije();
            forma.ShowDialog();
        }

        private void popunjenostToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStatistikaPopunjenosti form = new frmStatistikaPopunjenosti();
            form.ShowDialog();
        }

        private void vrstaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStatistikaVrstaSoba form = new frmStatistikaVrstaSoba();
            form.ShowDialog();
        }

        private void pregledStudenataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Forme_studenti.frmEvidencijaStudenata forma = new Forme_studenti.frmEvidencijaStudenata();
            forma.ShowDialog();
        }

        private void evidencijaKvarovaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Forme_kvarovi.frmEvidencijaKvarova forma = new Forme_kvarovi.frmEvidencijaKvarova(id);
            forma.ShowDialog();
        }

        private void odjavaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Uspješno ste se odjavili!", "Uspješna odjava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrijava forma = new frmPrijava();
            forma.ShowDialog();
        }

        private void evidencijaZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme_zaposlenici.frmEvidencijaZaposlenika forma = new Forme_zaposlenici.frmEvidencijaZaposlenika();
            forma.ShowDialog();
        }

        private void evidencijaRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme_racuni.frmEvidencijaRacuna forma = new Forme_racuni.frmEvidencijaRacuna(id);
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void rasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme_zaposlenici.frmRaspored forma = new Forme_zaposlenici.frmRaspored();
            forma.ShowDialog();
        }

        private void obracunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme_zaposlenici.frmObracun forma = new Forme_zaposlenici.frmObracun();
            forma.ShowDialog();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmPocetnaAdmin_Help forma = new Forme_help.frmPocetnaAdmin_Help();
            forma.ShowDialog();
        }

        private void Form1_Admin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }
    }
}
