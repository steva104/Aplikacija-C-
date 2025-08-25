using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Sertifikat : IEntity
    {
        public int IdSertifikat { get; set; }
        public string Naziv { get; set; }
        public string Institucija { get; set; }

        public string NazivTabele => "Sertifikat";

        public string Vrednosti => $"('{Naziv}','{Institucija}')";

        public string Uslov => $"idSertifikat={IdSertifikat}";

        public string Output => "idSertifikat";

        public string Kriterijum => "";

        public string JoinUslov => "";

        public string UpdateUslov => $"naziv='{Naziv}', institucija='{Institucija}'";

        public string UslovBezAlijasa => $"idSertifikat={IdSertifikat}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            Sertifikat se = new Sertifikat
            {
                IdSertifikat = (int)citac["idSertifikat"],
                Naziv = (string)citac["naziv"],
                Institucija = (string)citac["institucija"],
            };
            return se;
        }

    }
}
