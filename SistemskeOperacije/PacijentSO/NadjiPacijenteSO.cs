using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.PacijentSO
{
    public class NadjiPacijenteSO : OpstaSO
    {

        private string kriterijum;
        public List<Pacijent> Rezultat { get; private set; }
        public NadjiPacijenteSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }


        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.Pretraga(new Pacijent(), kriterijum).OfType<Pacijent>().ToList();
        }

    }
}
