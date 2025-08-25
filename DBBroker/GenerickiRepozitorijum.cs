using DBBroker;
using Microsoft.Data.SqlClient;
using Zajednicki.Domen;

namespace DBBroker
{
    public class GenerickiRepozitorijum : IGenerickiRepozitorijum
    {
        private Broker broker = new Broker();

        public void Commit()
        {
            broker.Commit();
        }
        public void OtvoriKonekciju()
        {
            broker.OpenConnection();
        }
        public void RollBack()
        {
            broker.Rollback();
        }
        public void ZapocniTransakciju()
        {
            broker.BeginTransakcion();
        }
        public void ZatvoriKonekciju()
        {
            broker.CloseConnection();
        }
        public int Sacuvaj(IEntity objekat)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"insert into {objekat.NazivTabele} output inserted.{objekat.Output} values {objekat.Vrednosti}";
            return (int)command.ExecuteScalar();
        }

        public int Izmeni(IEntity objekat)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"update {objekat.NazivTabele} set {objekat.UpdateUslov} where {objekat.UslovBezAlijasa}";
            return command.ExecuteNonQuery();

        }

        public int Izbrisi(IEntity objekat)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"delete from {objekat.NazivTabele} where {objekat.UslovBezAlijasa}";
            return command.ExecuteNonQuery();
        }

        public List<IEntity> VratiSve(IEntity objekat)
        {
            List<IEntity> lista = new List<IEntity>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {objekat.NazivTabele} {objekat.JoinUslov}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(objekat.ProcitajObjekat(reader));
                }
            }
            return lista;
        }

        public List<IEntity> Pretraga(IEntity objekat, string kriterijum)
        {
            List<IEntity> lista = new List<IEntity>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {objekat.NazivTabele} {objekat.JoinUslov} where ({objekat.Kriterijum} '%{kriterijum}%')";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(objekat.ProcitajObjekat(reader));
                }
            }
            return lista;
        }

        public IEntity VratiJedan(IEntity objekat)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {objekat.NazivTabele} {objekat.JoinUslov} where {objekat.Uslov}";
            IEntity rezultat;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }
                rezultat = objekat.ProcitajObjekat(reader);
            }
            return rezultat;
        }

        public List<IEntity> VratiSveZaNekog(IEntity objekat)
        {
            List<IEntity> lista = new List<IEntity>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {objekat.NazivTabele} {objekat.JoinUslov} where {objekat.Uslov}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(objekat.ProcitajObjekat(reader));
                }
            }
            return lista;
        }
    }
}
