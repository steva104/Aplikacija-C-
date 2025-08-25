using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using Klijent.Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.ZubarKontroler
{
    public class ZubarPrijavaController
    {
        private FrmLogin FrmLogin;
        private FrmMain FrmMain = new FrmMain();
        public ZubarPrijavaController(FrmLogin login)
        {
            FrmLogin = login;
        }

        public void Login()
        {
            TextBox txtKorisnickoIme = FrmLogin.txtKorisnickoIme;
            TextBox txtSifra = FrmLogin.txtSifra;

            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                MessageBox.Show("Unesite korisnicko ime.");
            }
            if (string.IsNullOrEmpty(txtSifra.Text))
            {
                MessageBox.Show("Unesite lozinku.");
            }

            Zajednicki.Domen.Zubar zubar = new Zajednicki.Domen.Zubar
            {
                KorisnickoIme = txtKorisnickoIme.Text,
                Sifra = txtSifra.Text
            };

            try
            {
                Communication.Instance.Connect();
                zubar = Communication.Instance.PosaljiZahtevVratiRezultat<Zajednicki.Domen.Zubar>(Operacija.Login, zubar);
                Session.Instance.TrenutnoPrijavljeni = zubar;
                MessageBox.Show("Korisnicko ime i sifra su ispravni"+"\n"+"Dobrodosli, " + zubar.Ime + " " + zubar.Prezime + "!","Uspesna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin.DialogResult = DialogResult.OK;
                if (FrmLogin.DialogResult == DialogResult.OK)
                {
                    FrmLogin.Hide();
                    FrmMain.ShowDialog();
                    //FrmLogin.Dispose();
                }
                else
                {
                    MessageBox.Show("Ne moze da se otvori glavna forma i meni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
