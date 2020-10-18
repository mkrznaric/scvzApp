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
    public partial class frmIspisRacuna : Form
    {
        private racun racunZaIspis;
        public frmIspisRacuna(racun proslijedjeniRacun)
        {
            InitializeComponent();
            racunZaIspis = proslijedjeniRacun;
            SakrijHeaderDGV();
            PripremiHeaderRacuna();
            DopuniStavke();
        }

        private void frmIspisRacuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ternarniDataSet.usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.ternarniDataSet.usluga);
            // TODO: This line of code loads data into the 'ternarniDataSet.racun_usluga' table. You can move, or remove it, as needed.
            this.racun_uslugaTableAdapter.Fill(this.ternarniDataSet.racun_usluga);
            // TODO: This line of code loads data into the 'ternarniDataSet.zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.ternarniDataSet.zaposlenik);
            // TODO: This line of code loads data into the 'ternarniDataSet.zupanija' table. You can move, or remove it, as needed.
            this.zupanijaTableAdapter.Fill(this.ternarniDataSet.zupanija);
            // TODO: This line of code loads data into the 'ternarniDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.ternarniDataSet.student);
            // TODO: This line of code loads data into the 'ternarniDataSet.racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.ternarniDataSet.racun);
        }

        private void SakrijHeaderDGV()
        {
            dgvRacun.RowHeadersVisible = false;
            dgvStavke.RowHeadersVisible = false;
        }
        private void PripremiHeaderRacuna()
        {
            racunBindingSource1.DataSource = racunZaIspis;
            lblUkupno.Text = racunZaIspis.ukupna_cijena.ToString() + ",00 kn";
            foreach (DataGridViewColumn c in dgvRacun.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            }
            foreach (DataGridViewColumn c in dgvStavke.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);
            }
        }

        private void DopuniStavke()
        {
            BindingList<racun_usluga> rusluge;
            using (var db = new scvzAppEntities())
            {
                rusluge = new BindingList<racun_usluga>(db.racun_usluga.ToList());
            }
            IEnumerable<racun_usluga> rez = from r in rusluge
                                            where r.racun_idracun == racunZaIspis.idracun
                                            select r;
            racunuslugaBindingSource.DataSource = rez.ToList();
            dgvRacun.ReadOnly = true;
            dgvStavke.ReadOnly = true;
            dgvRacun.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvStavke.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvRacun.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStavke.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Ispisi();
            Close();
        }

        Bitmap bmp;
        private void Ispisi()
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X + 40, this.Location.Y + 45, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
