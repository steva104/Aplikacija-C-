using Klijent.ServerKomunikacija;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Communication.Instance.ZatvoriKonekciju();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void ubaciPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUbaciPacijenta frmUbaciPacijenta = new FrmUbaciPacijenta();
            frmUbaciPacijenta.ShowDialog();
        }

        private void pacijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacijenti frmPacijenti = new FrmPacijenti();
            frmPacijenti.ShowDialog();
        }

        private void ubaciSertifikatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUbaciSertifikat frmUbaciSertifikat = new FrmUbaciSertifikat();
            frmUbaciSertifikat.ShowDialog();
        }

        private void ubaciEvidencijuPregledaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKreirajEvidencijuPregleda frmKreirajEvidencijuPregleda = new FrmKreirajEvidencijuPregleda();
            frmKreirajEvidencijuPregleda.ShowDialog();
        }

        private void evidencijePregledaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEvidencije frmEvidencije = new FrmEvidencije();
            frmEvidencije.ShowDialog();
        }
    }
}
