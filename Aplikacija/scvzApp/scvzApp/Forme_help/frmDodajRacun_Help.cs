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
    public partial class frmDodajRacun_Help : Form
    {
        public frmDodajRacun_Help()
        {
            InitializeComponent();
            textBox1.Text = "Izaberite studenta i način plaćanja računa iz pripadajućih padajaućih izbornika. " +
                "Odaberite stavku i unesite količinu pa kliknite na gumb Dodaj na račun kako bi dodali stavku." +
                " Stavke možete brisati s računa klikom na gumb Izbriši s računa. Nakon unosa potrebnih podataka klik na Ispiši" +
                " vodi prikazuje račun za ispis. Klik na gumb odustani vodi na prethodnu formu.";
        }
    }
}
