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
    public partial class frmEvidencijaRacuna_Help : Form
    {
        public frmEvidencijaRacuna_Help()
        {
            InitializeComponent();
            textBox1.Text = "Ova forma služi za pregled postojećih računa." +
                "Za brisanje računa odaberite račun i kliknite na Izbriši račun. Za dodavanje novog računa kliknite na" +
                "Novi račun. Za povratak kliknite na Izađi.";
        }
    }
}
