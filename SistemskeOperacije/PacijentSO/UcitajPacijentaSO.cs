using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.PacijentSO
{
    public class UcitajPacijentaSO :OpstaSO
    {
        public Pacijent Rezultat { get; private set; }
        private Pacijent pacijent;


        public UcitajPacijentaSO(Pacijent p)
        {
            this.pacijent = p;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = (Pacijent)repository.VratiJedan(pacijent);
        }

    }
}
