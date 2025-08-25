using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.EvidencijaPregledaKontroler
{
    public class PrikaziEvidencijuController
    {
        private FrmPrikaziEvidencijuPregleda forma;
        private EvidencijaPregleda trenutna;
        private BindingList<Zubar> zubari;
        private BindingList<Pacijent> pacijenti;
        public PrikaziEvidencijuController(FrmPrikaziEvidencijuPregleda form, EvidencijaPregleda e)
        {
            forma = form;
            trenutna = e;
            trenutna.StavkeZaBrisanje = new List<StavkaEvidencijePregleda>();
            Init();
        }

        private void Init()
        {
            try
            {
                forma.cmbZubari.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Zubar>>(Operacija.VratiListuSvihZubara);
                forma.cmbPacijenti.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(Operacija.VratiListuSvihPacijenata);
                forma.cmbTretman.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Tretman>>(Operacija.VratiListuSvihTretmana);
                forma.cmbZubari.DisplayMember = "FullName";
                forma.cmbPacijenti.DisplayMember = "FullName";
                forma.cmbTretman.DisplayMember = "NazivPlusCena";


                forma.cmbTretman.SelectedIndex = -1;
                forma.cmbZubari.Text = trenutna.ZubarFullName;
                forma.cmbPacijenti.Text = trenutna.PacijentFullName;
                forma.datePregled.Value = trenutna.DatumPregleda.ToDateTime(TimeOnly.Parse("10:00 PM"));
                forma.txtUkupnaCena.Text = trenutna.UkupnaCena.ToString();
                forma.txtVremePocetka.Text = trenutna.VremePocetka.ToString(@"hh\:mm");
                forma.txtVremeZavrsetka.Text = trenutna.VremeZavrsetka.ToString(@"hh\:mm");

                forma.dgvStavke.DataSource = trenutna.Stavke;
                forma.dgvStavke.Columns["IdEvidencijaPregleda"].Visible = false;
                forma.dgvStavke.Columns["NazivTabele"].Visible = false;
                forma.dgvStavke.Columns["Vrednosti"].Visible = false;
                forma.dgvStavke.Columns["Uslov"].Visible = false;
                forma.dgvStavke.Columns["Output"].Visible = false;
                forma.dgvStavke.Columns["Kriterijum"].Visible = false;
                forma.dgvStavke.Columns["JoinUslov"].Visible = false;
                forma.dgvStavke.Columns["UpdateUslov"].Visible = false;
                forma.dgvStavke.Columns["Tretman"].Visible = false;
                forma.dgvStavke.Columns["UslovBezAlijasa"].Visible = false;
                // forma.dgvStavke.Columns["Napomena"].Visible = false;
                forma.dgvStavke.Columns["Napomena"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                forma.dgvStavke.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                forma.dgvStavke.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                forma.dgvStavke.Columns["Rb"].HeaderText = "Redni broj";
                forma.dgvStavke.Columns["VrednostStavke"].HeaderText = "Vrednost stavke";
                forma.dgvStavke.Columns["NazivPregleda"].HeaderText = "Tretman";

            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DodajStavku()
        {
            Tretman selektovanTretman = (Tretman)forma.cmbTretman.SelectedItem;
            if (selektovanTretman == null)
            {

                return;
            }
            StavkaEvidencijePregleda s = new StavkaEvidencijePregleda
            {
                Tretman = (Tretman)forma.cmbTretman.SelectedItem,
                VrednostStavke = ((Tretman)forma.cmbTretman.SelectedItem).Cena,
                Napomena = forma.txtNapomena.Text,
                Rb = trenutna.Stavke.Count() + 1
            };
            trenutna.Stavke.Add(s);
            forma.dgvStavke.DataSource = null;
            forma.dgvStavke.DataSource = trenutna.Stavke;
            forma.dgvStavke.Columns["IdEvidencijaPregleda"].Visible = false;
            forma.dgvStavke.Columns["NazivTabele"].Visible = false;
            forma.dgvStavke.Columns["Vrednosti"].Visible = false;
            forma.dgvStavke.Columns["Uslov"].Visible = false;
            forma.dgvStavke.Columns["Output"].Visible = false;
            forma.dgvStavke.Columns["Kriterijum"].Visible = false;
            forma.dgvStavke.Columns["JoinUslov"].Visible = false;
            forma.dgvStavke.Columns["UpdateUslov"].Visible = false;
            forma.dgvStavke.Columns["Tretman"].Visible = false;
            forma.dgvStavke.Columns["UslovBezAlijasa"].Visible = false;
            // forma.dgvStavke.Columns["Napomena"].Visible = false;
            forma.dgvStavke.Columns["Napomena"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            forma.dgvStavke.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            forma.dgvStavke.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            forma.dgvStavke.Columns["Rb"].HeaderText = "Redni broj";
            forma.dgvStavke.Columns["VrednostStavke"].HeaderText = "Vrednost stavke";
            forma.dgvStavke.Columns["NazivPregleda"].HeaderText = "Tretman";

            trenutna.UkupnaCena += s.VrednostStavke;

            forma.txtUkupnaCena.Text = trenutna.UkupnaCena.ToString();
            forma.cmbTretman.SelectedIndex = -1;
            forma.txtNapomena.Text = "";
        }
        public void ObrisiStavku()
        {
            if (trenutna.Stavke.Count == 0)
            {
                MessageBox.Show("Nema stavke za brisanje", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (forma.dgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijednu stavku", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StavkaEvidencijePregleda selektovana = (StavkaEvidencijePregleda)forma.dgvStavke.SelectedRows[0].DataBoundItem;
            for (int i = selektovana.Rb; i < trenutna.Stavke.Count; i++)
            {
                trenutna.Stavke[i].Rb--;
            }


            trenutna.UkupnaCena -= selektovana.VrednostStavke;
            forma.txtUkupnaCena.Text = trenutna.UkupnaCena.ToString();

            
            trenutna.StavkeZaBrisanje.Add(selektovana);


            trenutna.Stavke.Remove(selektovana);
            // forma.dgvStavke.Refresh();
            forma.dgvStavke.DataSource = null;
            forma.dgvStavke.DataSource = trenutna.Stavke;
            forma.dgvStavke.Columns["IdEvidencijaPregleda"].Visible = false;
            forma.dgvStavke.Columns["NazivTabele"].Visible = false;
            forma.dgvStavke.Columns["Vrednosti"].Visible = false;
            forma.dgvStavke.Columns["Uslov"].Visible = false;
            forma.dgvStavke.Columns["Output"].Visible = false;
            forma.dgvStavke.Columns["Kriterijum"].Visible = false;
            forma.dgvStavke.Columns["JoinUslov"].Visible = false;
            forma.dgvStavke.Columns["UpdateUslov"].Visible = false;
            forma.dgvStavke.Columns["Tretman"].Visible = false;
            forma.dgvStavke.Columns["UslovBezAlijasa"].Visible = false;
            // forma.dgvStavke.Columns["Napomena"].Visible = false;
            forma.dgvStavke.Columns["Napomena"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            forma.dgvStavke.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            forma.dgvStavke.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            forma.dgvStavke.Columns["Rb"].HeaderText = "Redni broj";
            forma.dgvStavke.Columns["VrednostStavke"].HeaderText = "Vrednost stavke";
            forma.dgvStavke.Columns["NazivPregleda"].HeaderText = "Tretman";
        }

        public void Izmeni()
        {

            if (!ValidirajPodatke())
            {
                //MessageBox.Show("Sistem ne moze da izmeni evidenciju pregleda.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool validnoVreme1 = TimeSpan.TryParseExact(
           forma.txtVremePocetka.Text.Trim(),
            "hh\\:mm",
            null,
            out TimeSpan vremePocetka
           );

            if (!validnoVreme1)
            {
                MessageBox.Show("Unesite ispravno vreme početka u formatu HH:mm", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool validnoVreme2 = TimeSpan.TryParseExact(
                forma.txtVremeZavrsetka.Text.Trim(),
                "hh\\:mm",
                null,
                out TimeSpan vremeZavrsetka
            );

            if (!validnoVreme2)
            {
                MessageBox.Show("Unesite ispravno vreme završetka u formatu HH:mm", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (vremePocetka >= vremeZavrsetka)
            {
                MessageBox.Show("Vreme početka mora biti pre vremena završetka.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //try
            //{
            //    List<EvidencijaPregleda> evidencije = Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.EvidencijaPregleda>>(Operacija.VratiListuSvihEvidencijaPregleda);
            //    bool slobodno = MozeTermin(DateOnly.FromDateTime(forma.datePregled.Value), vremePocetka, vremeZavrsetka, ((Zubar)forma.cmbZubari.SelectedItem).IdZubar, evidencije);
            //    if (!slobodno)
            //    {
            //        MessageBox.Show("Zauzet termin!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show("Sistem ne moze da izmeni evidenciju pregleda.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}




            EvidencijaPregleda ek = new EvidencijaPregleda
            {
                IdEvidencijaPregleda = trenutna.IdEvidencijaPregleda,
                Zubar = (Zubar)forma.cmbZubari.SelectedItem,
                Pacijent = (Pacijent)forma.cmbPacijenti.SelectedItem,
                DatumPregleda = DateOnly.FromDateTime(forma.datePregled.Value),
                UkupnaCena = Int32.Parse(forma.txtUkupnaCena.Text),
                VremePocetka = vremePocetka,
                VremeZavrsetka = vremeZavrsetka,
                Stavke = trenutna.Stavke,
                StavkeZaBrisanje = trenutna.StavkeZaBrisanje
            };
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzmeniEvidenciju, ek);

                MessageBox.Show("Sistem je izmenio evidenciju pregleda", "Izmenjena evidencija pregleda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da izmeni evidenciju pregleda", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da izmeni evidenciju pregleda", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidirajPodatke()
        {
            if (trenutna.Stavke.Count == 0)
            {
                MessageBox.Show("Evidencija mora imati bar 1 stavku.");
                return false;
            }
            if (forma.cmbZubari.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da izaberete zubara.");
                return false;
            }

            if (forma.cmbPacijenti.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da izaberete pacijenta.");
                return false;
            }
            if (string.IsNullOrEmpty(forma.txtVremePocetka.Text))
            {
                MessageBox.Show("Molimo vas da unesete pocetno vreme pregleda.");
                return false;
            }
            if (string.IsNullOrEmpty(forma.txtVremeZavrsetka.Text))
            {
                MessageBox.Show("Molimo vas da unesete zavrsno vreme pregleda.");
                return false;
            }
            


            return true;
        }


        //public bool MozeTermin(DateOnly datum, TimeSpan pocetak, TimeSpan kraj, int idZubara, List<EvidencijaPregleda> evidencije)
        //{

        //    return !evidencije.Any(e =>
        //        e.Zubar.IdZubar == idZubara &&
        //        e.DatumPregleda == datum &&
        //        e.IdEvidencijaPregleda != trenutna.IdEvidencijaPregleda &&
        //        !(kraj <= e.VremePocetka || pocetak >= e.VremeZavrsetka)
        //    );
        //}
    }
}
