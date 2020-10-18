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
    public partial class frmSmjestiStudentaUSobu_Help : Form
    {
        public frmSmjestiStudentaUSobu_Help()
        {
            InitializeComponent();
            textBox1.Text = "Na popisu su prikazane samo slobodne sobe. Da smjestita studenta u jednu od soba, " +
                "odaberite sobu i kliknite na gumb Dodaj. Za povratak kliknite odustani.";
        }
    }
}
