using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.EvidencijaPregledaSO
{
    public class UcitajEvidencijuSO : OpstaSO
    {
        public EvidencijaPregleda Rezultat { get; private set; }
        private EvidencijaPregleda evidencija;

        public UcitajEvidencijuSO(EvidencijaPregleda e)
        {
            this.evidencija = e;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = (EvidencijaPregleda)repository.VratiJedan(evidencija);
            StavkaEvidencijePregleda s = new StavkaEvidencijePregleda
            {
                IdEvidencijaPregleda = Rezultat.IdEvidencijaPregleda
            };
            Rezultat.Stavke = repository.VratiSveZaNekog(s).OfType<StavkaEvidencijePregleda>().ToList();
        }


    }
}
