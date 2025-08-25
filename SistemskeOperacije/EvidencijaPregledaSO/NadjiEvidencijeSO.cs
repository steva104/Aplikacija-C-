using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.EvidencijaPregledaSO
{
    public class NadjiEvidencijeSO : OpstaSO
    {

        private string kriterijum;
        public List<EvidencijaPregleda> Rezultat { get; private set; }
        public NadjiEvidencijeSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }


        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.Pretraga(new EvidencijaPregleda(), kriterijum).OfType<EvidencijaPregleda>().ToList();
        }

    }
}
