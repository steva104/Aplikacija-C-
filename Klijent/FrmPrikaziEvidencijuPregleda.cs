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
using Zajednicki.Domen;

namespace Klijent
{
    public partial class FrmPrikaziEvidencijuPregleda : Form
    {
        PrikaziEvidencijuController controller;
        public FrmPrikaziEvidencijuPregleda(EvidencijaPregleda ev)
        {
            InitializeComponent();
            controller = new PrikaziEvidencijuController(this, ev);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controller.Izmeni();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            controller
                .ObrisiStavku();
        }
    }
}
