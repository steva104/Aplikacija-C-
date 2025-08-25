using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;


namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        protected IGenerickiRepozitorijum repository;

        public OpstaSO()
        {
            repository = new GenerickiRepozitorijum();
        }

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OtvoriKonekciju();
                repository.ZapocniTransakciju();
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception)
            {
                repository.RollBack();
                throw;
            }
            finally
            {
                repository.ZatvoriKonekciju();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity);


    }
}
