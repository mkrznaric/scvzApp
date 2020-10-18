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
    public partial class frmStatistikaPopunjenosti : Form
    {
        private void DohvatiPodatke()
        {
            using (var db = new scvzAppEntities())
            {
                List<soba> sobe;
                {
                    sobe = db.soba.ToList();
                }
                List<student> studenti;
                {
                    studenti = db.student.ToList();
                }

                IEnumerable<soba> slobodneSobe = from s in sobe
                                                where s.broj_kreveta > (from l in studenti where s.idsoba == l.student_soba select l).Count()
                                                select s;
                IEnumerable<soba> sveSobe = from s in sobe
                                                 select s;
                int brojSlobodnih = slobodneSobe.Count();
                int brojZauzetih = sveSobe.Count() - brojSlobodnih;
                chrtSobe.Titles.Add("Popunjenosti svih soba");
                chrtSobe.Series["s1"].IsValueShownAsLabel = true;
                chrtSobe.Series["s1"].Points.AddXY("Slobodne", brojSlobodnih);
                chrtSobe.Series["s1"].Points.AddXY("Zauzete", brojZauzetih);
            }
        }
        public frmStatistikaPopunjenosti()
        {
            InitializeComponent();
            DohvatiPodatke();
        }

        private void Btn_ZatvoriPomoc_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = false;
        }

        private void Btn_Pomoć_Click(object sender, EventArgs e)
        {
            pnl_Pomoc.Visible = true;
        }
    }
}
