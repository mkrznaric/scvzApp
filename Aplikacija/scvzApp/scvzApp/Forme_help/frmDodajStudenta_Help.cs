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
    public partial class frmDodajStudenta_Help : Form
    {
        public frmDodajStudenta_Help()
        {
            InitializeComponent();
            textBox1.Text = "Ova forma služi za dodavanje novog studenta. Unesite sve potrebne podatke i " +
                "kliknite Dodaj studenta kako bi dodali novog studenta u sustav. " +
                "Za povratak kliknite Odustani.";
        }
    }
}
