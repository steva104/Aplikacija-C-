using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.SertifikatK
{
    public class SertifikatController
    {
        private FrmUbaciSertifikat forma;

        public SertifikatController(FrmUbaciSertifikat forma)
        {
            this.forma = forma;
        }

        public void UbaciSertifikat()
        {

            if (!ValidirajPodatke())
            {
                //MessageBox.Show("Sistem ne moze da zapamti sertifikat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            Sertifikat s = new Sertifikat
            {
               Naziv = forma.txtNaziv.Text,
               Institucija =forma.txtInstitucija.Text,
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiSertifikat, s);

                MessageBox.Show("Sistem je zapamtio sertifikat.", "Sacuvan sertifikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da zapamti sertifkat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da zapamti sertifkat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void OcistiFormu()
        {
            forma.txtInstitucija.Text = "";
            forma.txtNaziv.Text = "";
        }

        private bool ValidirajPodatke()
        {
            if (string.IsNullOrWhiteSpace(forma.txtNaziv.Text))
            {
                MessageBox.Show("Polje za naziv sertifikata ne sme biti prazno.");
                return false;
            }
           
            if (forma.txtNaziv.Text.Length < 3 || forma.txtNaziv.Text.Length > 50)
            {
                MessageBox.Show("Naziv sertifikata mora imati između 3 i 50 karaktera.");
                return false;
            }

           
            //if (!System.Text.RegularExpressions.Regex.IsMatch(forma.txtNaziv.Text, @"^[A-Za-zšđčćžŠĐČĆŽ ]+$"))
            //{
            //    MessageBox.Show("Naziv sertifikata može sadržavati samo slova i razmake.");
            //    return false;
            //}

            if (string.IsNullOrWhiteSpace(forma.txtInstitucija.Text))
            {
                MessageBox.Show("Polje za instituciju ne sme biti prazno.");
                return false;
            }

            if (forma.txtInstitucija.Text.Length < 3 || forma.txtInstitucija.Text.Length > 50)
            {
                MessageBox.Show("Naziv institucije mora imati između 3 i 50 karaktera.");
                return false;
            }

            //if (!System.Text.RegularExpressions.Regex.IsMatch(forma.txtInstitucija.Text, @"^[A-Za-zšđčćžŠĐČĆŽ ]+$"))
            //{
            //    MessageBox.Show("Naziv institucije može sadržavati samo slova i razmake.");
            //    return false;
            //}

            return true;
        }
    }
}
