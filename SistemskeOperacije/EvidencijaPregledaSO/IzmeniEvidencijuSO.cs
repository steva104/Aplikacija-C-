using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.EvidencijaPregledaSO
{
    public class IzmeniEvidencijuSO : OpstaSO
    {
        private EvidencijaPregleda evidencija;
        public bool Rezultat { get; private set; }
        public IzmeniEvidencijuSO(EvidencijaPregleda e)
        {
            evidencija = e;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            List<EvidencijaPregleda> ev = repository.VratiSve(new EvidencijaPregleda()).OfType<EvidencijaPregleda>().ToList();

            if (ev.Any(e =>
                e.Zubar.IdZubar == evidencija.Zubar.IdZubar &&
                e.DatumPregleda == evidencija.DatumPregleda &&
                e.IdEvidencijaPregleda != evidencija.IdEvidencijaPregleda &&
                !(evidencija.VremeZavrsetka <= e.VremePocetka || evidencija.VremePocetka >= e.VremeZavrsetka)))
            {
                throw new Exception("Zauzet termin");
            }


            if (repository.Izmeni(evidencija) == 0)
            {
                Rezultat = false;
                return;
            }
           
            if (evidencija.StavkeZaBrisanje.Count > 0)
            {
                repository.Izbrisi(evidencija.StavkeZaBrisanje[0]);
            }
            else
            {
                evidencija.StavkeZaBrisanje = new List<StavkaEvidencijePregleda>();
                evidencija.StavkeZaBrisanje.Add(new StavkaEvidencijePregleda { IdEvidencijaPregleda = evidencija.IdEvidencijaPregleda });
                repository.Izbrisi(evidencija.StavkeZaBrisanje[0]);
            }
            foreach(var stavka in evidencija.Stavke)
            {
                if(stavka.IdEvidencijaPregleda == 0)
                {
                    stavka.IdEvidencijaPregleda = evidencija.IdEvidencijaPregleda;
                   

                }
                repository.Sacuvaj(stavka);

            }
            Rezultat = true;
        }

    }
}
