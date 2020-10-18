using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scvzApp.Forme_help
{
    public partial class frmEvidencijaStudenata_Help : Form
    {
        public frmEvidencijaStudenata_Help()
        {
            InitializeComponent();
            textBox1.Text = "Ova forma prikazuje sve studente iz baze podataka. Za dodavanje novog studenta kliknite na Novi student" +
                ". Odaberite studenta pa kliknite na Uredi studenta ili Izbriši studenta za ureuđivanje ili brisanje odabranog studenta. " +
                "Kliknite na Smjesti studenta u sobu kako bi studentu dodjelili u sobu. Klik na odustani vraća na prethdnu formu.";
        }
    }
}
