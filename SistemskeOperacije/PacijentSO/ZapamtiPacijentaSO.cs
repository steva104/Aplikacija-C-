using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.PacijentSO
{
    public class ZapamtiPacijentaSO : OpstaSO
    {

        private Pacijent pacijent;

        public ZapamtiPacijentaSO(Pacijent pacijent)
        {
            this.pacijent=pacijent;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Sacuvaj(entity);
        }

    }
}
