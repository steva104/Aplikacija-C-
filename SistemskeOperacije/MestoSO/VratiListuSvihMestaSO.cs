using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.MestoSO
{
    public class VratiListuSvihMestaSO : OpstaSO
    {
        public List<Mesto> Rezultat { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.VratiSve(new Mesto()).OfType<Mesto>().ToList();
        }


    }
}
