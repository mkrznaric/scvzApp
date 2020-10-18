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
    public partial class frmUrediKvar_Help : Form
    {
        public frmUrediKvar_Help()
        {
            InitializeComponent();
            textBox1.Text = "Ova forma služi za uređivanje kvarova." +
                " Unesite sve podatke pa kliknite Spremi izmjene kako bi " +
                "spremili izmjene u bazi podataka. Za povratak bez promjena kliknite Odustani.";
        }
    }
}
