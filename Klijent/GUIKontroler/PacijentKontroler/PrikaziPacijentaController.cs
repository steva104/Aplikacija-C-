using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.PacijentKontroler
{
   public class PrikaziPacijentaController
    {
        private FrmPrikaziPacijenta forma;
        private Pacijent trenutni;
        public PrikaziPacijentaController(FrmPrikaziPacijenta form, Pacijent p)
        {
            forma = form;
            trenutni = p;
            Init();
        }

        private void Init()
        {
            try
            {
                forma.cmbMesto.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Mesto>>(Operacija.VratiListuSvihMesta);
                forma.cmbMesto.DisplayMember = "Naziv";
                forma.cmbMesto.Text = trenutni.Mesto.Naziv;

                forma.txtIme.Text = trenutni.Ime;
                forma.txtPrezime.Text = trenutni.Prezime;
                forma.txtEmail.Text = trenutni.Email;
                forma.txtBrojTelefona.Text = trenutni.BrojTelefona;

            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        public void Izmeni()
        {
            if (!ValidirajPodatke())
            {
                //MessageBox.Show("Sistem ne moze da zapamti pacijenta.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacijent p = new Pacijent
            {
                IdPacijent = trenutni.IdPacijent,
                Ime = forma.txtIme.Text,
                Prezime = forma.txtPrezime.Text,
                BrojTelefona =forma.txtBrojTelefona.Text,
                Email = forma.txtEmail.Text,
                Mesto = (Mesto)forma.cmbMesto.SelectedItem
            };
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzmeniPacijenta, p);

                MessageBox.Show("Sistem je zapamtio pacijenta.", "Izmenjen pacijent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da izmeni pacijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da izmeni pacijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Obrisi()
        {
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ObrisiPacijenta, trenutni);
                MessageBox.Show("Sistem je obrisao pacijenta.", "Obrisan pacijent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da obrise pacijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da obrise pacijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidirajPodatke()
        {
            if (forma.cmbMesto.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas izaberite mesto.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(forma.txtIme.Text))
            {
                MessageBox.Show("Polje za ime ne sme biti prazno.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(forma.txtBrojTelefona.Text))
            {
                MessageBox.Show("Polje za broj telefona ne sme biti prazno.");
                return false;
            }
            if (!forma.txtBrojTelefona.Text.StartsWith("+381"))
            {
                MessageBox.Show("Polje za broj telefona mora zapocinjati sa +381");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(forma.txtIme.Text, @"^[A-ZŠĐČĆŽ][a-zšđčćž]+$"))
            {
                MessageBox.Show("Ime može sadržavati samo slova i mora poceti velikim slovom.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(forma.txtPrezime.Text))
            {
                MessageBox.Show("Polje za prezime ne sme biti prazno.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(forma.txtPrezime.Text, @"^[A-ZŠĐČĆŽ][a-zšđčćž]+$"))
            {
                MessageBox.Show("Prezime može sadržavati samo slova i mora poceti velikim slovom.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(forma.txtEmail.Text))
            {
                MessageBox.Show("Polje za email ne sme biti prazno.");
                return false;
            }

            if (!forma.txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email mora sadržavati '@'.");
                return false;
            }

            return true;
        }
    }
}
