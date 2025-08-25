using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class ZS :IEntity
    {
        public DateOnly DatumIzdavanja { get; set; }

        public Zubar Zubar { get; set; }
        public Sertifikat Sertifikat { get; set; }

        public string NazivTabele => "ZS";

        public string Vrednosti => $"{DatumIzdavanja},{Sertifikat.IdSertifikat},{Zubar.IdZubar}";

        public string Uslov => "";

        public string Output => "";

        public string Kriterijum => "";

        public string JoinUslov => "zs join Zubar z on (zs.idZubar=z.idZubar) join Sertifikat se on (zs.idSertifikat=se.idSertifikat)";

        public string UpdateUslov => "";

        public string UslovBezAlijasa => throw new NotImplementedException();

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            ZS zs = new ZS
            {
                DatumIzdavanja = DateOnly.FromDateTime((DateTime)citac["datumIzdavanja"]),
                Zubar = new Zubar
                {
                    IdZubar = (int)citac["idZubar"],
                    Ime = (string)citac["ime"],
                    Prezime = (string)citac["prezime"],
                },
                Sertifikat = new Sertifikat
                {
                    IdSertifikat = (int)citac["idSertifikat"],
                    Naziv = (string)citac["naziv"],
                    Institucija = (string)citac["institucija"],
                }

            };
            return zs;
        }




    }
}
