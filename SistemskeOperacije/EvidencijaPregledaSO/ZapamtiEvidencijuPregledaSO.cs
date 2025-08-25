using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace SistemskeOperacije.EvidencijaPregledaSO
{
    public class ZapamtiEvidencijuPregledaSO : OpstaSO
    {

        private EvidencijaPregleda evidencija;
        public ZapamtiEvidencijuPregledaSO(EvidencijaPregleda evidencija)
        {
            this.evidencija = evidencija;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            List<EvidencijaPregleda> ev = repository.VratiSve(new EvidencijaPregleda()).OfType<EvidencijaPregleda>().ToList();

            if (ev.Any(e =>
                e.Zubar.IdZubar == evidencija.Zubar.IdZubar &&
                e.DatumPregleda == evidencija.DatumPregleda &&
                !(evidencija.VremeZavrsetka <= e.VremePocetka || evidencija.VremePocetka >= e.VremeZavrsetka)))
            {
                throw new Exception("Zauzet termin");
            }

            int id = repository.Sacuvaj(entity);
            foreach (StavkaEvidencijePregleda se in evidencija.Stavke)
            {
                se.IdEvidencijaPregleda = id;
                repository.Sacuvaj(se);
            }
        }

    }
}
