using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp.Forme_studenti
{
    public partial class frmSmjestiStudentaUSobu : Form
    {
        private student odabraniStudent;

        public frmSmjestiStudentaUSobu(student studentZaIzmjenu)
        {
            InitializeComponent();
            odabraniStudent = studentZaIzmjenu;
            PrikaziSobe();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrikaziSobe()
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

                IEnumerable<soba> zauzeteSobe = from s in sobe
                                  where s.broj_kreveta > (from l in studenti where s.idsoba == l.student_soba select l).Count()
                                  select s;
                
                sobaBindingSource.DataSource = zauzeteSobe.ToList();
            }
        }

        private void btnSmjesti_Click(object sender, EventArgs e)
        {
            SmjestiStudenta();
        }

        private void frmSmjestiStudentaUSobu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ternarniDataSet.soba' table. You can move, or remove it, as needed.
            this.sobaTableAdapter.Fill(this.ternarniDataSet.soba);
        }

        private void SmjestiStudenta()
        {
            soba odabranaSoba = dgvSlobodneSobe.CurrentRow.DataBoundItem as soba;
            int brojSobe = odabranaSoba.idsoba;

            using (var db = new scvzAppEntities())
            {
                db.student.Attach(odabraniStudent);
                odabraniStudent.student_soba = brojSobe;
                db.SaveChanges();
            }
            Close();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmSmjestiStudentaUSobu_Help forma = new Forme_help.frmSmjestiStudentaUSobu_Help();
            forma.ShowDialog();
        }
    }
}
