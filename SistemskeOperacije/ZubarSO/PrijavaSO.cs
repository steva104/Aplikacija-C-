using Zajednicki.Domen;

namespace SistemskeOperacije.ZubarSO
{
    public class PrijavaSO : OpstaSO
    {
        public Zubar Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Zubar zub = (Zubar)entity;

         

            foreach (Zubar z in repository.VratiSve(new Zubar()))
            {
                if (z.KorisnickoIme == zub.KorisnickoIme && z.Sifra == zub.Sifra)
                {
                    Result = z;
                }
            }
        }
    }
}
