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
    public partial class frmUrediStudenta_Help : Form
    {
        public frmUrediStudenta_Help()
        {
            InitializeComponent();
            textBox1.Text = "Ova forma služi za uređivanje odabranog studenta. Unesite sve potrebne podatke i " +
                "kliknite Izmijeni studenta kako bi promijenili podatke o studentu. " +
                "Za povratak kliknite Odustani.";
        }
    }
}
