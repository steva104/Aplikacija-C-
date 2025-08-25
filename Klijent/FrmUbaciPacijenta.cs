using Klijent.GUIKontroler.PacijentKontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmUbaciPacijenta : Form
    {


        private PacijentController controller;
        public FrmUbaciPacijenta()
        {
            InitializeComponent();
            controller = new PacijentController(this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
           controller.UbaciPacijenta();
        }
    }
}
