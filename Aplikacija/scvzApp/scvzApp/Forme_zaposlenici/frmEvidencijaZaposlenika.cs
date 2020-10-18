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
    public partial class frmEvidencijaZaposlenika : Form
    {
        public frmEvidencijaZaposlenika()
        {
            InitializeComponent();
        }


        private void frmEvidencijaZaposlenika_Load(object sender, EventArgs e)
        {
            PrikaziZaposlenike();
        }

        public void PrikaziZaposlenike()
        {
            using (var db = new scvzAppEntities())
            {

                var upit = from z in db.zaposlenik
                           from t in db.tip_zaposlenika
                           where z.zaposlenik_tip_zaposlenika==t.idtip_zaposlenika
                           select z;

                dgvZaposlenici.DataSource = upit.ToList();

                dgvZaposlenici.Columns[0].HeaderText = "ID";
                dgvZaposlenici.Columns[1].HeaderText = "Ime";
                dgvZaposlenici.Columns[2].HeaderText = "Prezime";
                dgvZaposlenici.Columns[3].HeaderText = "Korisnicko ime";
                dgvZaposlenici.Columns[4].HeaderText = "Telefon";
                dgvZaposlenici.Columns[5].HeaderText = "Adresa";
                dgvZaposlenici.Columns[6].HeaderText = "Lozinka";


                dgvZaposlenici.Columns[7].Visible = false;
                dgvZaposlenici.Columns[8].Visible = false;
                dgvZaposlenici.Columns[9].Visible = false;
                dgvZaposlenici.Columns[10].Visible = false;
                dgvZaposlenici.Columns[11].Visible = false;
                dgvZaposlenici.Columns[12].Visible = false;
            }
        }

        private void btnOdustaniZaposlenik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            frmDodajZaposlenika forma = new frmDodajZaposlenika();
            forma.ShowDialog();
            PrikaziZaposlenike();
        }

        private void btnIzbrisiZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.CurrentRow != null)
            {
                zaposlenik odabraniZaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as zaposlenik;
                if (odabraniZaposlenik != null)
                {
                    if (MessageBox.Show("Sigrno želite izbrisati zaposlenika?", "Upozorenje", MessageBoxButtons.YesNo)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new scvzAppEntities())
                        {
                            db.zaposlenik.Attach(odabraniZaposlenik);
                            db.zaposlenik.Remove(odabraniZaposlenik);
                            db.SaveChanges();
                        }
                        PrikaziZaposlenike();
                    }
                }
            }
        }

        private void btnUrediZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.CurrentRow != null)
            {
                zaposlenik odabraniZaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as zaposlenik;
                if (odabraniZaposlenik != null)
                {
                    frmUrediZaposlenika forma = new frmUrediZaposlenika(odabraniZaposlenik);
                    forma.ShowDialog();
                    PrikaziZaposlenike();
                }
            }
        }

        private void dgvZaposlenici_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvZaposlenici.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[7].Value) == 1)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                }
            }
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmEvidencijaZaposlenika_Help forma = new Forme_help.frmEvidencijaZaposlenika_Help();
            forma.ShowDialog();
        }

        private void frmEvidencijaZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                lblPomoc_Click(sender, e);
            }
        }

        private void dgvZaposlenici_KeyDown(object sender, KeyEventArgs e)
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
