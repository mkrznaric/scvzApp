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
    public partial class frmDodajKvar_Help : Form
    {
        public frmDodajKvar_Help()
        {
            InitializeComponent();
            textBox1.Text = "Ova forma služi za dodavanje novog kvara. Unesite sve potrebne podatke i " +
                "kliknite Dodaj kvar kako bi dodali novi kvar. " +
                "Za povratak kliknite Odustani.";
        }
    }
}
