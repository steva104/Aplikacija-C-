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

namespace Klijent.GUIKontroler.PacijentKontroler
{
    public class SviPacijentiController
    {
        private FrmPacijenti forma;
        private BindingList<Pacijent> pacijenti;

        public SviPacijentiController(FrmPacijenti p)
        {
            forma = p;
            Init();
        }

        private void Init()
        {
            try
            {
                InicijalizujDgvPacijenti(Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(Operacija.VratiListuSvihPacijenata));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InicijalizujDgvPacijenti(List<Pacijent> lista)
        {
            pacijenti = new BindingList<Pacijent>(lista);
            forma.dgvPacijenti.DataSource = pacijenti;


            forma.dgvPacijenti.Columns["IdPacijent"].Visible = false;
            forma.dgvPacijenti.Columns["Ime"].Visible = false;
            forma.dgvPacijenti.Columns["Prezime"].Visible = false;
            forma.dgvPacijenti.Columns["Mesto"].Visible = false;
            forma.dgvPacijenti.Columns["NazivTabele"].Visible = false;
            forma.dgvPacijenti.Columns["Vrednosti"].Visible = false;
            forma.dgvPacijenti.Columns["Uslov"].Visible = false;
            forma.dgvPacijenti.Columns["Output"].Visible = false;
            forma.dgvPacijenti.Columns["Kriterijum"].Visible = false;
            forma.dgvPacijenti.Columns["JoinUslov"].Visible = false;
            forma.dgvPacijenti.Columns["UpdateUslov"].Visible = false;
            forma.dgvPacijenti.Columns["UslovBezAlijasa"].Visible = false;

            forma.dgvPacijenti.Columns["FullName"].HeaderText = "Pacijent";
            forma.dgvPacijenti.Columns["MestoPrebivalista"].HeaderText = "Mesto prebivalista";
            forma.dgvPacijenti.Columns["BrojTelefona"].HeaderText = "Broj telefona";
        }
        public void NadjiPacijenta()
        {
            if (forma.txtKriterijum.Text == "")
            {
                MessageBox.Show("Nista niste uneli kao kriterijum", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string kriterijum = forma.txtKriterijum.Text;
                pacijenti = new BindingList<Pacijent>();
                InicijalizujDgvPacijenti(Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(Operacija.NadjiPacijente, kriterijum));
                MessageBox.Show("Sistem je nasao pacijente po zadatom kriterijumu!", "Nadjeni pacijenti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da pronadje pacijente po zadatom kriterijumu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InicijalizujDgvPacijenti(Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(Operacija.VratiListuSvihPacijenata));
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da pronadje pacijente po zadatom kriterijumu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrikaziPacijenta()
        {
            if (forma.dgvPacijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati red u tabeli.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Pacijent p = (Pacijent)forma.dgvPacijenti.SelectedRows[0].DataBoundItem;
            try
            {
                p = Communication.Instance.PosaljiZahtevVratiRezultat<Pacijent>(Operacija.UcitajPacijenta, p);
                MessageBox.Show("Sistem je nasao pacijenta.", "Nadjen pacijent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PokreniFormu(p);

                InicijalizujDgvPacijenti(Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(Operacija.VratiListuSvihPacijenata));
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da ucita pacijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show("Sistem ne moze da ucita pacijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InicijalizujDgvPacijenti(Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(Operacija.VratiListuSvihPacijenata));
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da ucita pacijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PokreniFormu(Pacijent p)
        {
            FrmPrikaziPacijenta frm = new FrmPrikaziPacijenta(p);
            frm.ShowDialog();
            return;
        }
    }
}
