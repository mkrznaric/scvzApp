using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp.Forme_kvarovi
{
    public partial class frmUrediKvar : Form
    {
        private kvar odabraniKvar;
        private int id;
        public frmUrediKvar(kvar kvarZaIzmjenu, int broj)
        {
            id = broj;
            InitializeComponent();
            odabraniKvar = kvarZaIzmjenu;
            PopuniFormu();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SpremiPromjene();
        }

        private void frmUrediKvar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekundarniDataSet.soba' table. You can move, or remove it, as needed.
            this.sobaTableAdapter1.Fill(this.sekundarniDataSet.soba);
            // TODO: This line of code loads data into the 'primarni_DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.primarni_DataSet.student);
            // TODO: This line of code loads data into the 'primarni_DataSet.zupanija' table. You can move, or remove it, as needed.
            this.zupanijaTableAdapter.Fill(this.primarni_DataSet.zupanija);
            // TODO: This line of code loads data into the 'primarni_DataSet.zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.primarni_DataSet.zaposlenik);
        }

        private void SpremiPromjene()
        {
            using (var db = new scvzAppEntities())
            {
                db.kvar.Attach(odabraniKvar);
                odabraniKvar.opis = txtOpis.Text;
                odabraniKvar.datum_prijave = txtDatum.Value;
                odabraniKvar.kvar_idsoba = int.Parse(cmbSoba.SelectedValue.ToString());
                odabraniKvar.kvar_zaprimio_idzaposlenik = id;
                odabraniKvar.kvar__prijavio_idstudent = int.Parse(cmbKvarPrijavio.SelectedValue.ToString());
                odabraniKvar.status_kvara = cmbStatus.SelectedItem.ToString();
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno uređen kvar!");
            Close();
        }

        private void PopuniFormu()
        {
            txtOpis.Text = odabraniKvar.opis;
            txtDatum.Value = DateTime.Parse(odabraniKvar.datum_prijave.ToString());
            cmbKvarPrijavio.SelectedValue = odabraniKvar.kvar__prijavio_idstudent;
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            Forme_help.frmUrediKvar_Help forma = new Forme_help.frmUrediKvar_Help();
            forma.ShowDialog();
        }
    }
}
