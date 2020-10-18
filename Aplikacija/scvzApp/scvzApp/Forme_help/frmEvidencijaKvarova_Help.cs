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
    public partial class frmEvidencijaKvarova_Help : Form
    {
        public frmEvidencijaKvarova_Help()
        {
            InitializeComponent();
            textBox1.Text = "Ova forma služi za pregled kvarova. Za brisanje kvara odaberite kvar s " +
                "popisa i kliknita na Izbriši kvar. " +
                "Za uređivanje postojećeg kvara odaberite kvar s popisa i kliknite na Uredi kvar. " +
                "Za dodavanje novog kvara kliknite na Novi kvar" +
                "Za povratak kliknite Izađi";
        }
    }
}
