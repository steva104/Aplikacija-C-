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
using Zajednicki.Domen;

namespace Klijent
{
    public partial class FrmPrikaziPacijenta : Form
    {
        PrikaziPacijentaController controller;
        public FrmPrikaziPacijenta(Pacijent p)
        {
            InitializeComponent();
            controller = new PrikaziPacijentaController(this, p);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controller.Izmeni();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            controller.Obrisi();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
