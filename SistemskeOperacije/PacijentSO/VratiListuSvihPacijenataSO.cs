using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.PacijentSO
{
    public class VratiListuSvihPacijenataSO : OpstaSO
    {
        public List<Pacijent> Rezultat { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.VratiSve(new Pacijent()).OfType<Pacijent>().ToList();
        }


    }
}
