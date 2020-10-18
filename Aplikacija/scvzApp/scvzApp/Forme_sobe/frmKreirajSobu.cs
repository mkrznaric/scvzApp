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
    public partial class frmKreirajSobu : Form
    {
        public frmKreirajSobu()
        {
            InitializeComponent();
            cmbKreveti.Items.Add("1");
            cmbKreveti.Items.Add("2");
            cmbKreveti.Items.Add("3");
            cmbKreveti.SelectedIndex = 0;
        }
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnKreiraj_Click(object sender, EventArgs e)
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
                using (var db = new scvzAppEntities())
                {
                    var upit = from s in db.soba
                               where s.broj_sobe == brojSobe
                               select s;
                    if (upit.Any())
                    {
                        MessageBox.Show("Soba s ovim brojem već postoji");
                        return;
                    }
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            using (var db = new scvzAppEntities())
            {
                soba soba = new soba();
                soba.broj_sobe = int.Parse(txtBrojSobe.Text);
                soba.broj_kreveta = cmbKreveti.SelectedIndex + 1;
                db.soba.Add(soba);
                db.SaveChanges();
            }
            Close();
        }

        private void Btn_pomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = true;
        }

        private void Btn_ZatvoriPomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = false;
        }
    }
}
