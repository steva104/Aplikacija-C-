using Klijent.GUIKontroler.EvidencijaPregledaKontroler;
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
    public partial class FrmKreirajEvidencijuPregleda : Form
    {
        private EvidencijaPregledaController controller;


        public FrmKreirajEvidencijuPregleda()
        {
            InitializeComponent();
            controller = new EvidencijaPregledaController(this);
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            controller.ObrisiStavku();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controller.KreirajEvidenciju();
        }
    }
}
