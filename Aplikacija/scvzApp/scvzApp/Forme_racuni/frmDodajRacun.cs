using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp.Forme_racuni
{
    public partial class frmDodajRacun : Form
    {
        private racun noviRacun;
        public frmDodajRacun(racun proslijedjenRacun)
        {
            InitializeComponent();
            noviRacun = proslijedjenRacun;
            OsvjeziDGV();
        }

        private void frmDodajRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primarni_DataSet.racun_usluga' table. You can move, or remove it, as needed.
            this.racun_uslugaTableAdapter.Fill(this.primarni_DataSet.racun_usluga);
            // TODO: This line of code loads data into the 'primarni_DataSet.usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.primarni_DataSet.usluga);
            // TODO: This line of code loads data into the 'primarni_DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.primarni_DataSet.student);

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            using (var db = new scvzAppEntities())
            {
                db.racun.Attach(noviRacun);
                db.racun.Remove(noviRacun);
                db.SaveChanges();
            }
            Close();
        }

        private void DodajStavku()
        {
            using (var db = new scvzAppEntities())
            {
                racun_usluga novaStavka = new racun_usluga();
                novaStavka.racun_idracun = noviRacun.idracun;
                novaStavka.usluga_idusluga = int.Parse(cmbStavke.SelectedValue.ToString());
                novaStavka.kolicina = short.Parse(txtKolicina.Text.ToString());
                
                db.racun_usluga.Add(novaStavka);
                db.SaveChanges();
            }
        }

        private void NadopuniRacun()
        {
            using (var db = new scvzAppEntities())
            {
                db.racun.Attach(noviRacun);
                noviRacun.racun_student = int.Parse(cmbStudenti.SelectedValue.ToString());
                noviRacun.nacin_placanja = cmbNacinPlacanja.SelectedItem.ToString();
                noviRacun.ukupna_cijena = IzracunajCijenu();
                db.SaveChanges();
            }
        }
        private void OsvjeziDGV()
        {
            BindingList<racun_usluga> rusluge;
            using (var db = new scvzAppEntities())
            {
                rusluge = new BindingList<racun_usluga>(db.racun_usluga.ToList());
            }
            IEnumerable<racun_usluga> rez = from r in rusluge
                                            where r.racun_idracun == noviRacun.idracun
                                            select r;
            racunuslugaBindingSource.DataSource = rez.ToList();
        }

        private double IzracunajCijenu()
        {
            BindingList<usluga> usluge;
            using (var db = new scvzAppEntities())
            {
                usluge = new BindingList<usluga>(db.usluga.ToList());
            }

            int cijena = 0;
            foreach(DataGridViewRow r in dgvrusluga.Rows)
            {
                IEnumerable<int> u = from a in usluge
                                     where a.idusluga == int.Parse(r.Cells[1].Value.ToString())
                                     select int.Parse(a.cijena.ToString());
                List<int> n = u.ToList();
                cijena += int.Parse(r.Cells[2].Value.ToString()) * n[0];
            }
            return cijena;
        }

        private void BrisiStavku()
        {
            if (dgvrusluga.CurrentRow != null)
            {
                racun_usluga odabranaRusluga = dgvrusluga.CurrentRow.DataBoundItem as racun_usluga;
                if (odabranaRusluga != null)
                {
                    if (MessageBox.Show("Sigrno želite izbrisati stavku?", "Upozorenje", MessageBoxButtons.YesNo)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new scvzAppEntities())
                        {
                            db.racun_usluga.Attach(odabranaRusluga);
                            db.racun_usluga.Remove(odabranaRusluga);
                            db.SaveChanges();
                        }
                        OsvjeziDGV();
                    }
                }
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            DodajStavku();
            OsvjeziDGV();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            NadopuniRacun();
            frmIspisRacuna forma = new frmIspisRacuna(noviRacun);
            this.Hide();
            forma.ShowDialog();
            Close();
        }

        private void btnIzbrisiStavku_Click(object sender, EventArgs e)
        {
            BrisiStavku();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmDodajRacun_Help forma = new Forme_help.frmDodajRacun_Help();
            forma.ShowDialog();
        }
    }
}
