using System;
using System.Linq;
using System.Windows.Forms;

namespace scvzApp
{
    public partial class frmPromjenaSobe : Form
    {
        soba sobaStart;
        private void PopuniPolja(soba soba)
        {
            txtBrojSobe.Text = soba.broj_sobe.ToString();
            cmbKreveti.Items.Add("1");
            cmbKreveti.Items.Add("2");
            cmbKreveti.Items.Add("3");
            cmbKreveti.SelectedIndex = cmbKreveti.FindStringExact(soba.broj_kreveta.ToString());
        }
        public frmPromjenaSobe()
        {
            InitializeComponent();
        }
        public frmPromjenaSobe(soba soba)
        {
            InitializeComponent();
            sobaStart = soba;
            PopuniPolja(sobaStart);
            btnPromijeni.Enabled = false;
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPromijeni.Enabled = true;
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnObriši_Click(object sender, EventArgs e)
        {
            using (var db = new scvzAppEntities())
            {
                int brojSobe = int.Parse(txtBrojSobe.Text);
                var upit = from s in db.soba
                           where s.broj_sobe == sobaStart.broj_sobe
                           select s;
                foreach (var item in upit)
                {
                    db.soba.Remove(item);
                }
                db.SaveChanges();
            }
            Close();
        }

        private void BtnPromijeni_Click(object sender, EventArgs e)
        {
            using (var db = new scvzAppEntities())
            {
                int brojSobe = 0;
                try
                {
                    if (int.TryParse(txtBrojSobe.Text, out brojSobe))
                    {
                        brojSobe = int.Parse(txtBrojSobe.Text);
                    }
                    else
                        throw new System.FormatException("Broj sobe nije dobro unesen!");
                    if (brojSobe != sobaStart.broj_sobe)
                    {
                        var upit = from s in db.soba
                                   where s.broj_sobe == brojSobe
                                   select s;
                        if (upit.Any())
                        {
                            MessageBox.Show("Soba s ovim brojem vec postoji");
                            return;
                        }
                    }
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                int brojKreveta = cmbKreveti.SelectedIndex + 1;
                soba soba = (from s in db.soba
                             where s.broj_sobe == sobaStart.broj_sobe
                             select s).SingleOrDefault();
                soba.broj_kreveta = brojKreveta;
                soba.broj_sobe = brojSobe;
                db.SaveChanges();
            }
            MessageBox.Show("Promjene pohranjene");
            Close();
        }

        private void CmbKreveti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPromijeni.Enabled = true;
        }

        private void Btn_Pomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = true;
        }

        private void Btn_ZatvoriPomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = false;
        }

        private void TxtBrojSobe_TextChanged(object sender, EventArgs e)
        {
            btnPromijeni.Enabled = true;

        }
    }
}