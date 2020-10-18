using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace scvzApp
{
    public partial class frmEvidencijaSoba : Form
    {
        public void PopuniKvaroveIStudente(soba soba) {
            using (var db = new scvzAppEntities())
            {
                int columnIndex = dgvSobe.Columns.Cast<DataGridViewColumn>().Single(x => x.HeaderText == "idsoba").Index;
                DataGridViewRow row = dgvSobe.Rows.Cast<DataGridViewRow>().Single(x => (int)x.Cells[columnIndex].Value == soba.idsoba);

                var upitKvar = from k in db.kvar
                               where k.kvar_idsoba == soba.idsoba
                               select new { Id = k.idkvar, opis = k.opis };

                var kvarovi = upitKvar.ToList();
                if (!kvarovi.Any())
                    kvarovi.Add(new { Id = 0, opis = "Nema prijavljenih kvarova" });

                DataGridViewComboBoxCell kvarCell = ((DataGridViewComboBoxCell)row.Cells[3]);
                kvarCell.ValueMember = "Id";
                kvarCell.DisplayMember = "opis";
                kvarCell.DataSource = kvarovi;

                if (kvarovi.Any())
                    kvarCell.Value = kvarovi.First().Id;

                var upitStudent = from s in db.student
                                  where s.student_soba == soba.idsoba
                                  select new { Id = s.idstudent, ime = s.ime + " " + s.prezime };

                var studenti = upitStudent.ToList();
                if (!studenti.Any())
                    studenti.Add(new { Id = 0, ime = "Nema prijavljenih studenata" });

                DataGridViewComboBoxCell studentCell = ((DataGridViewComboBoxCell)row.Cells[4]);
                studentCell.ValueMember = "Id";
                studentCell.DisplayMember = "ime";
                studentCell.DataSource = studenti;

                if (studenti.Any())
                    studentCell.Value = studenti.First().Id;
            }
        }
        private void DohvatiPodatke()
        {
            using (var db = new scvzAppEntities())
            {
                var upit = from s in db.soba.Include("kvar").Include("student")
                           orderby s.broj_sobe ascending
                           select s;
                var sobe = upit.ToList();
                dgvSobe.DataSource = sobe;
                foreach (var soba in sobe)
                {
                    PopuniKvaroveIStudente(soba);
                }
                btnIzmjeni.Visible = false;
            }
        }
        private void Filtriraj(string tekst, int vrsta)
        {
            using (var db = new scvzAppEntities())
            {
                switch (vrsta)
                {
                    case 0:
                        int brojSobe = int.Parse(tekst);

                        var upitBrojSobe = from s in db.soba
                                           where s.broj_sobe == brojSobe
                                           orderby s.broj_sobe ascending
                                           select s;
                        dgvSobe.DataSource = upitBrojSobe.ToList();
                        foreach (var soba in upitBrojSobe)
                        {
                            PopuniKvaroveIStudente(soba);
                        }
                        break;
                    case 1:
                        int brojKreveta = int.Parse(tekst);
                        var upitBrojKreveta = from s in db.soba
                                              where s.broj_kreveta == brojKreveta
                                              orderby s.broj_sobe ascending
                                              select s;
                        dgvSobe.DataSource = upitBrojKreveta.ToList();
                        foreach (var soba in upitBrojKreveta)
                        {
                            PopuniKvaroveIStudente(soba);
                        }
                        break;

                }

            }
        }
        public frmEvidencijaSoba()
        {
            InitializeComponent();
        }

        private void FrmEvidencijaSoba2_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Add("Broj sobe");
            cmbFilter.Items.Add("Broj kreveta");
            cmbFilter.SelectedIndex = 0;
            using (var db = new scvzAppEntities())
            {
                var upit = from s in db.soba.Include("kvar").Include("student")
                           orderby s.broj_sobe ascending
                           select s;
                var sobe = upit.ToList();
                foreach (var soba in sobe)
                {
                    PopuniKvaroveIStudente(soba);
                }
            }
        }

        private void TxtPretrazi_TextChanged(object sender, EventArgs e)
        {
            string unos = txtPretrazi.Text;
            if (unos != null && unos != "")
            {
                if (cmbFilter.SelectedIndex == 0 || cmbFilter.SelectedIndex == 1)
                {
                    int value;
                    if (!int.TryParse(unos, out value)) MessageBox.Show("Ne možete pretražiti brojeve slovom");
                    else
                    {
                        int dodatniFilter = cmbFilter.SelectedIndex;
                        Filtriraj(unos, dodatniFilter);
                    }
                }
                else
                {
                    int dodatniFilter = cmbFilter.SelectedIndex;
                    Filtriraj(unos, dodatniFilter);
                }
            }
            else DohvatiPodatke();
        }

        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            DohvatiPodatke();
            txtPretrazi.Text = "";
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPretrazi.Text != null && txtPretrazi.Text != "")
            {
                string pretraga = txtPretrazi.Text;
                int dodatniFilter = cmbFilter.SelectedIndex;
                Filtriraj(pretraga, dodatniFilter);
            }
            else DohvatiPodatke();
        }

        private void DgvSobe_SelectionChanged(object sender, EventArgs e)
        {
            btnIzmjeni.Visible = true;
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            frmKreirajSobu form = new frmKreirajSobu();
            form.Enabled = true;
            form.ShowDialog();
            DohvatiPodatke();
        }
        private void BtnIzmjeni_Click(object sender, EventArgs e)
        {
            soba soba = dgvSobe.CurrentRow.DataBoundItem as soba;
            frmPromjenaSobe form = new frmPromjenaSobe(soba);
            form.ShowDialog();
            DohvatiPodatke();
        }

        private void Btn_Pomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = true;
        }

        private void Btn_ZatvoriPomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = false;
        }
    }
}