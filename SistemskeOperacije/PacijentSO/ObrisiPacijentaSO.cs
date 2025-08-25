using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.PacijentSO
{
    public class ObrisiPacijentaSO :OpstaSO
    {
        private Pacijent pacijent;
        public bool Rezultat { get; private set; }

        public ObrisiPacijentaSO(Pacijent pacijent)
        {
            this.pacijent = pacijent;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            if (repository.Izbrisi(pacijent) == 0)
            {
                Rezultat = false;
                return;
            }
            Rezultat = true;
        }

    }
}
