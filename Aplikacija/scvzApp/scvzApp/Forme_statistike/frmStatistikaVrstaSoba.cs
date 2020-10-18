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
    public partial class frmStatistikaVrstaSoba : Form
    {
        private void DohvatiPodatke()
        {
            using (var db = new scvzAppEntities())
            {
                var upit = from s in db.soba
                           select s;
                List<soba> sobe = upit.ToList();
                int brojJednokre = 0;
                int brojDvokre = 0;
                int brojTrokre = 0;
                foreach (var soba in sobe)
                {
                    if (soba.broj_kreveta == 1)
                    {
                        brojJednokre++;
                    }
                    if (soba.broj_kreveta == 2)
                    {
                        brojDvokre++;
                    }
                    if (soba.broj_kreveta == 3)
                    {
                        brojTrokre++;
                    }
                }
                chrtVrsteSoba.Titles.Add("Popunjenosti svih soba");
                chrtVrsteSoba.Series["Broj Soba"].IsValueShownAsLabel = true;
                chrtVrsteSoba.Series["Broj Soba"].Points.AddXY("Jednokrevetne", brojJednokre);
                chrtVrsteSoba.Series["Broj Soba"].Points.AddXY("Dvokrevetne", brojDvokre);
                chrtVrsteSoba.Series["Broj Soba"].Points.AddXY("Trokrevetne", brojTrokre);

            }
        }
        public frmStatistikaVrstaSoba()
        {
            InitializeComponent();
            DohvatiPodatke();
        }

        private void FrmStatistikaVrstaSoba_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ZatvoriPomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = false;
        }

        private void Btn_Pomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = true;
        }
    }
}
