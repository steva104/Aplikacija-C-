using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.EvidencijaPregledaSO
{
    public class VratiListuSvihEvidencijaPregledaSO : OpstaSO
    {
        public List<EvidencijaPregleda> Rezultat { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.VratiSve(new EvidencijaPregleda()).OfType<EvidencijaPregleda>().ToList();
        }


    }
}
