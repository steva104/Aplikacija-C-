using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.PacijentSO
{
    public class IzmeniPacijentaSO :OpstaSO
    {
        private Pacijent pacijent;
        public bool Rezultat { get; private set; }
        public IzmeniPacijentaSO(Pacijent p)
        {
            pacijent = p;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            if (repository.Izmeni(pacijent) == 0)
            {
                Rezultat = false;
                return;
            }
            Rezultat = true;
        }


    }
}
