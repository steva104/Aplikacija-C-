using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijentSoket;
        private bool kraj = false;
        private JsonNetworkSerializer helper;

        public ClientHandler(Socket klijentSoket)
        {
            this.klijentSoket = klijentSoket;
            helper = new JsonNetworkSerializer(klijentSoket);
        }
        private readonly object lockObject = new object();
        public void ObradiZahteve()
        {
            try
            {
                while (true)
                {
                    Zahtev zahtev = helper.Receive<Zahtev>();
                    Odgovor odgovor;
                    try
                    {
                        odgovor = KreirajOdgovor(zahtev);
                    }
                    catch (Exception ex)
                    {
                        odgovor = new Odgovor();
                        odgovor.Signal = false;
                        odgovor.Poruka = ex.Message;
                    }

                    helper.Send(odgovor);

                    // Sinhronizuj pristup kraju
                    lock (lockObject)
                    {
                        if (kraj)
                        {
                            break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>>> Klijent zatvorio formu: " + ex.Message);
            }
            finally
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (klijentSoket != null)
            {
                klijentSoket.Shutdown(SocketShutdown.Both);
                klijentSoket.Dispose();
                klijentSoket = null;
                Debug.WriteLine(">>>> Ugasen klijentski soket.");
            }
        }

        private Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();

            switch (zahtev.Operacija)
            {
                case Operacija.Login:
                    Zubar z = JsonSerializer.Deserialize<Zubar>((JsonElement)zahtev.Podaci);
                    odgovor.Podaci = Kontroler.Instance.Login(z);
                    if (odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Korisnicko ime i/ili sifra nisu ispravni.";
                    }
                    break;
                case Operacija.Kraj:
                    kraj = true;
                    break;
                case Operacija.VratiListuSvihZubara:
                    odgovor.Podaci = Kontroler.Instance.VratiSveZubare();
                    break;
                case Operacija.VratiListuSvihPacijenata:
                    odgovor.Podaci = Kontroler.Instance.VratiSvePacijente();
                    break;
                case Operacija.VratiListuSvihTretmana:
                    odgovor.Podaci = Kontroler.Instance.VratiSveTretmane();
                    break;
                case Operacija.VratiListuSvihEvidencijaPregleda:
                    odgovor.Podaci = Kontroler.Instance.VratiSveEvidencijePregleda();
                    break;
                case Operacija.VratiListuSvihMesta:
                    odgovor.Podaci = Kontroler.Instance.VratiSvaMesta();
                    break;
                case Operacija.NadjiEvidencije:
                    string zzz = JsonSerializer.Deserialize<String>((JsonElement)zahtev.Podaci);
                    List<EvidencijaPregleda> pronadjeneEvidencije = Kontroler.Instance.NadjiEvidencije(zzz);
                    if (pronadjeneEvidencije.Count == 0)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da pronadje evidencije pregleda po zadatom kriterijumu.";
                    }
                    else
                    {
                        odgovor.Podaci = pronadjeneEvidencije;
                    }

                    break;
                case Operacija.NadjiPacijente:
                    string pomoc = JsonSerializer.Deserialize<String>((JsonElement)zahtev.Podaci);
                    List<Pacijent> pronadjeniPacijenti = Kontroler.Instance.NadjiPacijente(pomoc);
                    if (pronadjeniPacijenti.Count == 0)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da pronadje pacijente po zadatom kriterijumu.";
                    }
                    else
                    {
                        odgovor.Podaci = pronadjeniPacijenti;
                    }

                    break;
                case Operacija.UcitajEvidenciju:
                    EvidencijaPregleda ek = JsonSerializer.Deserialize<EvidencijaPregleda>((JsonElement)zahtev.Podaci);
                    odgovor.Podaci = Kontroler.Instance.UcitajEvidenciju(ek);
                    if (odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da ucita evidenciju pregleda.";
                    }
                    break;
                case Operacija.UcitajPacijenta:
                    Pacijent pac = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                    odgovor.Podaci = Kontroler.Instance.UcitajPacijenta(pac);
                    if (odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da ucita pacijenta.";
                    }
                    break;
                case Operacija.ZapamtiEvidencijuPregleda:
                    try
                    {
                        EvidencijaPregleda e = JsonSerializer.Deserialize<EvidencijaPregleda>((JsonElement)zahtev.Podaci);
                        Kontroler.Instance.DodajEvidenciju(e);
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da sacuva evidenciju pregleda!";
                    }
                    break;
                case Operacija.ZapamtiPacijenta:
                    try
                   {
                       Pacijent p = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                        Kontroler.Instance.DodajPacijenta(p);
                   }
                   catch (SqlException)
                   {
                       odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da sacuva pacijenta!";
                   }
                    break;
                case Operacija.ZapamtiSertifikat:
                    try
                    {
                        Sertifikat sert = JsonSerializer.Deserialize<Sertifikat>((JsonElement)zahtev.Podaci);
                        Kontroler.Instance.DodajSertifikat(sert);
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da sacuva sertifikat!";
                    }
                    break;
                case Operacija.IzmeniEvidenciju:
                    try
                    {
                        EvidencijaPregleda po = JsonSerializer.Deserialize<EvidencijaPregleda>((JsonElement)zahtev.Podaci);
                        if (!Kontroler.Instance.IzmeniEvidenciju(po))
                        {
                            odgovor.Signal = false;
                            odgovor.Poruka = "Sistem ne moze da izmeni evidenciju!";
                        }

                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da izmeni evidenciju!";
                    }
                    break;
                case Operacija.IzmeniPacijenta:
                    try
                    {
                        Pacijent paci = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                        if (!Kontroler.Instance.IzmeniPacijenta(paci))
                        {
                            odgovor.Signal = false;
                            odgovor.Poruka = "Sistem ne moze da izmeni pacijenta!";
                        }

                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da izmeni pacijenta!";
                    }
                    break;
                case Operacija.ObrisiPacijenta:
                    try
                    {
                        Pacijent pacc = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                        if (!Kontroler.Instance.ObrisiPacijenta(pacc))
                        {
                            odgovor.Poruka = "Sistem ne moze da obrise pacijenta!";
                            odgovor.Signal = false;
                        }
                    }
                    catch (SqlException)
                    {
                        odgovor.Poruka = "Sistem ne moze da obrise pacijenta!";
                        odgovor.Signal = false;
                    }

                    break;
            }
            return odgovor;
        }



    }
}
