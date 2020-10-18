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
    public partial class Form1 : Form
    {
        private int id;

        public Form1(int broj)
        {
            InitializeComponent();
            id = broj;
        }

        private void PretražiSobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvidencijaSoba form = new frmEvidencijaSoba();
            form.ShowDialog();
        }

        private void pregledStudenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme_studenti.frmEvidencijaStudenata forma = new Forme_studenti.frmEvidencijaStudenata();
            forma.ShowDialog();
        }

        private void kvaroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme_kvarovi.frmEvidencijaKvarova forma = new Forme_kvarovi.frmEvidencijaKvarova(id);
            forma.ShowDialog();
        }

        private void evidencijaKvarovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme_kvarovi.frmEvidencijaKvarova forma = new Forme_kvarovi.frmEvidencijaKvarova(id);
            forma.ShowDialog();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Uspješno ste se odjavili!", "Uspješna odjava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrijava forma = new frmPrijava();
            forma.ShowDialog();
        }

        private void evidencijaRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme_racuni.frmEvidencijaRacuna forma = new Forme_racuni.frmEvidencijaRacuna(id);
            forma.ShowDialog();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmPocetna_Help forma = new Forme_help.frmPocetna_Help();
            forma.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }
    }
}
