using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Tretman : IEntity
    {

        public int IdTretman { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public int Cena { get; set; }

        public string NazivPlusCena => Naziv + " - " + Cena;
        public string NazivTabele => "Tretman";

        public string Vrednosti => $"{Naziv},{Trajanje},{Cena}";

        public string Uslov => $"idTretman={IdTretman}";

        public string Output => "idTretman";

        public string Kriterijum => "";

        public string JoinUslov => "";

        public string UpdateUslov => "";

        public string UslovBezAlijasa => $"idTretman={IdTretman}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            Tretman t = new Tretman
            {
                IdTretman = (int)citac["idTretman"],
                Naziv = (string)citac["naziv"],
                Trajanje = (int)citac["trajanje"],
                Cena = (int)citac["cena"],
            };
            return t;
        }


    }
}
