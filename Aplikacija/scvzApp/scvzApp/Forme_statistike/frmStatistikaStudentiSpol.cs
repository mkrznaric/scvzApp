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
    public partial class frmStatistikaStudentiSpol : Form
    {
        private void DohvatiPodatke()
        {
            using (var db = new scvzAppEntities())
            {
                var upit = from s in db.student
                           select s;
                List<student> studenti = upit.ToList();
                int brojMuskih = 0;
                int brojZenskih = 0;
                foreach (var student in studenti)
                {
                    if (student.spol.Contains("M"))
                    {
                        brojMuskih++;
                    }
                    else
                    {
                        brojZenskih++;
                    }
                }
                chrtStudenti.Titles.Add("Statistika studenata po spolu");
                chrtStudenti.Series["s1"].IsValueShownAsLabel = true;
                chrtStudenti.Series["s1"].Points.AddXY("Muškarci", brojMuskih);
                chrtStudenti.Series["s1"].Points.AddXY("Žene", brojZenskih);
            }
        }
        public frmStatistikaStudentiSpol()
        {
            InitializeComponent();
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
