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
    public class SveEvidencijeController
    {

        private FrmEvidencije forma;
        private BindingList<EvidencijaPregleda> evidencije;
        public SveEvidencijeController(FrmEvidencije ev)
        {
            forma = ev;
            Init();
        }

        private void Init()
        {
            try
            {
                InicijalizujDgvEvidencije(Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.EvidencijaPregleda>>(Operacija.VratiListuSvihEvidencijaPregleda).OrderBy(e => e.DatumPregleda).ThenBy(e => e.VremePocetka).ToList());
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void InicijalizujDgvEvidencije(List<Zajednicki.Domen.EvidencijaPregleda> lista)
        {
            evidencije = new BindingList<Zajednicki.Domen.EvidencijaPregleda>(lista);
            forma.dgvEvidencije.DataSource = evidencije;


            forma.dgvEvidencije.Columns["IdEvidencijaPregleda"].Visible = false;
            forma.dgvEvidencije.Columns["Zubar"].Visible = false;
            forma.dgvEvidencije.Columns["Pacijent"].Visible = false;

            forma.dgvEvidencije.Columns["NazivTabele"].Visible = false;
            forma.dgvEvidencije.Columns["Vrednosti"].Visible = false;
            forma.dgvEvidencije.Columns["Uslov"].Visible = false;
            forma.dgvEvidencije.Columns["Output"].Visible = false;
            forma.dgvEvidencije.Columns["Kriterijum"].Visible = false;
            forma.dgvEvidencije.Columns["JoinUslov"].Visible = false;
            forma.dgvEvidencije.Columns["UpdateUslov"].Visible = false;
            forma.dgvEvidencije.Columns["UslovBezAlijasa"].Visible = false;

            forma.dgvEvidencije.Columns["DatumPregleda"].HeaderText = "Datum pregleda";
            forma.dgvEvidencije.Columns["UkupnaCena"].HeaderText = "Ukupna cena";
            forma.dgvEvidencije.Columns["ZubarFullName"].HeaderText = "Zubar";
            forma.dgvEvidencije.Columns["PacijentFullName"].HeaderText = "Pacijent";
            forma.dgvEvidencije.Columns["VremePocetka"].HeaderText = "Početak pregleda";
            forma.dgvEvidencije.Columns["VremeZavrsetka"].HeaderText = "Kraj pregleda";
        }
        public void NadjiEvidenciju()
        {
            if (forma.txtKriterijum.Text == "")
            {
                MessageBox.Show("Nista niste uneli kao kriterijum", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string kriterijum = forma.txtKriterijum.Text;
                evidencije = new BindingList<Zajednicki.Domen.EvidencijaPregleda>();
                InicijalizujDgvEvidencije(Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.EvidencijaPregleda>>(Operacija.NadjiEvidencije, kriterijum).OrderBy(e => e.DatumPregleda).ThenBy(e => e.VremePocetka).ToList());
                MessageBox.Show("Sistem je nasao evidencije po zadatom kritertijumu!","Pronadjene evidencije", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServerCommunicationException e)
            {
                MessageBox.Show("Sistem ne moze da pronadje evidencije pregleda po zadatom kriterijumu.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InicijalizujDgvEvidencije(Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.EvidencijaPregleda>>(Operacija.VratiListuSvihEvidencijaPregleda).OrderBy(e => e.DatumPregleda).ThenBy(e => e.VremePocetka).ToList());
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da pronadje evidencije pregleda po zadatom kriterijumu.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void PrikaziEvidenciju()
        {
            if (forma.dgvEvidencije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate da izaberete evidenciju pregleda", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EvidencijaPregleda ev = (EvidencijaPregleda)forma.dgvEvidencije.SelectedRows[0].DataBoundItem;
            try
            {
                ev = Communication.Instance.PosaljiZahtevVratiRezultat<EvidencijaPregleda>(Operacija.UcitajEvidenciju, ev);
                MessageBox.Show("Sistem je ucitao evidenciju pregleda!", "Pronadjena evidencija pregleda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PokreniFormu(ev);

                InicijalizujDgvEvidencije(Communication.Instance.PosaljiZahtevVratiRezultat<List<EvidencijaPregleda>>(Operacija.VratiListuSvihEvidencijaPregleda).OrderBy(e => e.DatumPregleda).ThenBy(e => e.VremePocetka).ToList());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da ucita evidenciju pregleda.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InicijalizujDgvEvidencije(Communication.Instance.PosaljiZahtevVratiRezultat<List<EvidencijaPregleda>>(Operacija.VratiListuSvihEvidencijaPregleda).OrderBy(e => e.DatumPregleda).ThenBy(e => e.VremePocetka).ToList());
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da ucita evidenciju pregleda.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PokreniFormu(EvidencijaPregleda ev)
        {
            FrmPrikaziEvidencijuPregleda frm = new FrmPrikaziEvidencijuPregleda(ev);
            frm.ShowDialog();
            return;
        }
    }
}
