using System.Net.Sockets;

namespace Server
{
    public partial class FrmServer : Form
    {

        private Server s;

        public FrmServer()
        {
            InitializeComponent();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                Thread serverNit = new Thread(s.Listen);
                serverNit.IsBackground = true;
                serverNit.Start();
                label1.Text = "Server je ukljucen";
            }
            catch (IOException)
            {
                MessageBox.Show("Server ne moze da se pokrene!");
            }
            catch (SocketException)
            {
                MessageBox.Show("Server je vec pokrenut!");
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            label1.Text = "Server je iskljucen";
            MessageBox.Show("Server je zaustavljen!","Server iskljucen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
