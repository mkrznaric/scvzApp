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
    public partial class frmEvidencijaStudenata : Form
    {
        public frmEvidencijaStudenata()
        {
            InitializeComponent();
            PrikaziStudente();
        }

        private void PrikaziStudente()
        {
            BindingList<student> studenti;
            using (var db = new scvzAppEntities())
            {
                studenti = new BindingList<student>(db.student.ToList());
            }
            studentBindingSource2.DataSource = studenti;
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            frmDodajStudenta forma = new frmDodajStudenta();
            forma.ShowDialog();
            PrikaziStudente();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            UrediStudenta();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            IzbrisiStudenta();
        }

        private void btnSmjestiUSobu_Click(object sender, EventArgs e)
        {
            SmjestiStudentaUSobu();
        }

        private void frmEvidencijaStudenata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekundarniDataSet.fakultet' table. You can move, or remove it, as needed.
            this.fakultetTableAdapter2.Fill(this.sekundarniDataSet.fakultet);
            // TODO: This line of code loads data into the 'ternarniDataSet.fakultet' table. You can move, or remove it, as needed.
            this.fakultetTableAdapter1.Fill(this.ternarniDataSet.fakultet);
            // TODO: This line of code loads data into the 'ternarniDataSet.soba' table. You can move, or remove it, as needed.
            this.sobaTableAdapter1.Fill(this.ternarniDataSet.soba);
            // TODO: This line of code loads data into the 'ternarniDataSet.zupanija' table. You can move, or remove it, as needed.
            this.zupanijaTableAdapter1.Fill(this.ternarniDataSet.zupanija);
            // TODO: This line of code loads data into the 'ternarniDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.ternarniDataSet.student);
        }

        private void UrediStudenta()
        {
            if (dgvStudenti.CurrentRow != null)
            {
                student odabraniStudent = dgvStudenti.CurrentRow.DataBoundItem as student;
                if (odabraniStudent != null)
                {
                    frmUrediStudenta forma = new frmUrediStudenta(odabraniStudent);
                    forma.ShowDialog();
                    PrikaziStudente();
                }
            }
        }

        private void SmjestiStudentaUSobu()
        {
            if (dgvStudenti.CurrentRow != null)
            {
                student odabraniStudent = dgvStudenti.CurrentRow.DataBoundItem as student;
                if (odabraniStudent != null)
                {
                    frmSmjestiStudentaUSobu forma = new frmSmjestiStudentaUSobu(odabraniStudent);
                    forma.ShowDialog();
                    PrikaziStudente();
                }
            }
        }

        private void IzbrisiStudenta()
        {
            if (dgvStudenti.CurrentRow != null)
            {
                student odabraniStudent = dgvStudenti.CurrentRow.DataBoundItem as student;
                if (odabraniStudent != null)
                {
                    if (MessageBox.Show("Sigrno želite izbrisati studenta?", "Upozoenje", MessageBoxButtons.YesNo)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new scvzAppEntities())
                        {
                            db.student.Attach(odabraniStudent);
                            db.student.Remove(odabraniStudent);
                            db.SaveChanges();
                        }
                        PrikaziStudente();
                    }
                }
            }
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmEvidencijaStudenata_Help forma = new Forme_help.frmEvidencijaStudenata_Help();
            forma.ShowDialog();
        }
    }

}
