using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.ZubarSO
{
    public class VratiListuSvihZubaraSO : OpstaSO
    {

        public List<Zubar> Rezultat { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.VratiSve(new Zubar()).OfType<Zubar>().ToList();
        }

    }
}
