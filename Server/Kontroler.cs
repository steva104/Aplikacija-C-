using DBBroker;
using SistemskeOperacije;
using SistemskeOperacije.EvidencijaPregledaSO;
using SistemskeOperacije.MestoSO;
using SistemskeOperacije.PacijentSO;
using SistemskeOperacije.SertifikatSO;
using SistemskeOperacije.TretmanSO;
using SistemskeOperacije.ZubarSO;
using Zajednicki.Domen;

namespace Server
{
    public class Kontroler
    {
        private IGenerickiRepozitorijum repository;
        private static Kontroler instance;
        private static object _lock = new object();
        private Kontroler()
        {
            repository = new GenerickiRepozitorijum();
        }
        public static Kontroler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Kontroler();
                        }
                    }
                }
                return instance;
            }
        }
        public Zubar Login(Zubar z)
        {
            PrijavaSO so = new PrijavaSO();
            so.ExecuteTemplate(z);
            return so.Result;
        }
        public List<Mesto> VratiSvaMesta()
        {
            OpstaSO so = new VratiListuSvihMestaSO();
            so.ExecuteTemplate(new Mesto());
            return ((VratiListuSvihMestaSO)so).Rezultat;
        }
        public void DodajPacijenta(Pacijent p)
        {
            OpstaSO so = new ZapamtiPacijentaSO(p);
            so.ExecuteTemplate(p);
        }
        public List<Pacijent> VratiSvePacijente()
        {
            OpstaSO so = new VratiListuSvihPacijenataSO();
            so.ExecuteTemplate(new Pacijent());
            return ((VratiListuSvihPacijenataSO)so).Rezultat;
        }
        public List<Pacijent> NadjiPacijente(string kriterijum)
        {
            OpstaSO so = new NadjiPacijenteSO(kriterijum);
            so.ExecuteTemplate(new Pacijent());
            return ((NadjiPacijenteSO)so).Rezultat;
        }
        public Pacijent UcitajPacijenta(Pacijent p)
        {
            OpstaSO so = new UcitajPacijentaSO(p);
            so.ExecuteTemplate(new Pacijent());
            return ((UcitajPacijentaSO)so).Rezultat;
        }
        public bool IzmeniPacijenta(Pacijent p)
        {
            OpstaSO so = new IzmeniPacijentaSO(p);
            so.ExecuteTemplate(new Pacijent());
            return ((IzmeniPacijentaSO)so).Rezultat;
        }
        public bool ObrisiPacijenta(Pacijent p)
        {
            OpstaSO so = new ObrisiPacijentaSO(p);
            so.ExecuteTemplate(new Pacijent());
            return ((ObrisiPacijentaSO)so).Rezultat;
        }
        public void DodajSertifikat(Sertifikat se)
        {
            OpstaSO so = new ZapamtiSertifikatSO(se);
            so.ExecuteTemplate(se);
        }
        public List<Zubar> VratiSveZubare()
        {
            OpstaSO so = new VratiListuSvihZubaraSO();
            so.ExecuteTemplate(new Zubar());
            return ((VratiListuSvihZubaraSO)so).Rezultat;
        }
        public List<Tretman> VratiSveTretmane()
        {
            OpstaSO so = new VratiListuSvihTretmanaSO();
            so.ExecuteTemplate(new Tretman());
            return ((VratiListuSvihTretmanaSO)so).Rezultat;
        }
        public void DodajEvidenciju(EvidencijaPregleda ek)
        {
            OpstaSO so = new ZapamtiEvidencijuPregledaSO(ek);
            so.ExecuteTemplate(ek);
        }
        public List<EvidencijaPregleda> VratiSveEvidencijePregleda()
        {
            OpstaSO so = new VratiListuSvihEvidencijaPregledaSO();
            so.ExecuteTemplate(new EvidencijaPregleda());
            return ((VratiListuSvihEvidencijaPregledaSO)so).Rezultat;
        }

        public List<EvidencijaPregleda> NadjiEvidencije(string kriterijum)
        {
            OpstaSO so = new NadjiEvidencijeSO(kriterijum);
            so.ExecuteTemplate(new EvidencijaPregleda());
            return ((NadjiEvidencijeSO)so).Rezultat;
        }
        public EvidencijaPregleda UcitajEvidenciju(EvidencijaPregleda e)
        {
            OpstaSO so = new UcitajEvidencijuSO(e);
            so.ExecuteTemplate(new EvidencijaPregleda());
            return ((UcitajEvidencijuSO)so).Rezultat;
        }
        public bool IzmeniEvidenciju(EvidencijaPregleda e)
        {
            OpstaSO so = new IzmeniEvidencijuSO(e);
            so.ExecuteTemplate(new EvidencijaPregleda());
            return ((IzmeniEvidencijuSO)so).Rezultat;
        }
    }
}
