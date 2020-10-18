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
    public partial class frmStatistikaZupanije : Form
    {
        private void DohvatiPodatke()
        {
            using (var db = new scvzAppEntities())
            {
                var test = from s in db.student
                           select s;

                var grouped = test.Select(x => x.zupanija1.naziv).Distinct().ToDictionary<string, string, int>(x => x, x => 0);

                foreach(student s in test)
                {
                    grouped[s.zupanija1.naziv]++;
                }
                chrtZupanije.Titles.Add("Broj studenata po županiji");

                foreach (var kvp in grouped)
                {
                    chrtZupanije.Series["Naziv zupanije"].IsValueShownAsLabel = true;
                    chrtZupanije.Series["Naziv zupanije"].Points.AddXY(kvp.Key, kvp.Value);
                }
            }
        }
                public frmStatistikaZupanije()
        {
            InitializeComponent();
            DohvatiPodatke();
        }

        private void FrmStatistikaZupanije_Load(object sender, EventArgs e)
        {

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
