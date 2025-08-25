using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Mesto : IEntity
    {
        public int IdMesto{ get; set; }
        public string Naziv { get; set; }
        public int Ptt { get; set; }

        public string NazivTabele => "Mesto";

        public string Vrednosti => $"{Naziv},{Ptt}";

        public string Uslov => $"idMesto={IdMesto}";

        public string Output => "idMesto";

        public string Kriterijum => "";

        public string JoinUslov => "";

        public string UpdateUslov => "";

        public string UslovBezAlijasa => $"idMesto={IdMesto}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            Mesto m = new Mesto
            {
                IdMesto = citac.GetInt32(0),
                Naziv = citac.GetString(1),
                Ptt = citac.GetInt32(2)
            };
            return m;
        }


    }
}
