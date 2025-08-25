using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.TretmanSO
{
    public class VratiListuSvihTretmanaSO : OpstaSO
    {

        public List<Tretman> Rezultat { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.VratiSve(new Tretman()).OfType<Tretman>().ToList();
        }

    }
}
