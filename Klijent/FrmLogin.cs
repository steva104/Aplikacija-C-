using Klijent.GUIKontroler.ZubarKontroler;

namespace Klijent
{
    public partial class FrmLogin : Form
    {

        private ZubarPrijavaController prijava;

        public FrmLogin()
        {
            InitializeComponent();
            prijava = new ZubarPrijavaController(this);
            txtKorisnickoIme.Text = "zubar123";
            txtSifra.Text = "sifra123";
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            prijava.Login();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
