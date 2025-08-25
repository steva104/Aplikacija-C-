using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class StavkaEvidencijePregleda : IEntity
    {
        public int Rb { get; set; }
        public int VrednostStavke {  get; set; }
        public string Napomena {  get; set; }
        public int IdEvidencijaPregleda { get; set; }
        public Tretman Tretman { get; set; }

        public string NazivPregleda => Tretman?.Naziv;


        public string NazivTabele => "StavkaEvidencijePregleda";

        public string Vrednosti => $"({IdEvidencijaPregleda},{Rb},{VrednostStavke},'{Napomena}',{Tretman.IdTretman})";

        public string Uslov => $"ste.idEvidencijaPregleda={IdEvidencijaPregleda}";

        public string Output => "rb";

        public string Kriterijum => "";

        public string JoinUslov => "ste join EvidencijaPregleda e on (ste.idEvidencijaPregleda=e.idEvidencijaPregleda) join Tretman t on (ste.idTretman=t.idTretman)";

        public string UpdateUslov => $"rb={Rb}";

        public string UslovBezAlijasa => $"idEvidencijaPregleda={IdEvidencijaPregleda}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            //StavkaEvidencijePregleda st = new StavkaEvidencijePregleda
            //{
            //    Rb = (int)citac["rb"],
            //    DatumPrisustva = (DateOnly)citac["datumPrisustva"],
            //    Ocena = (decimal)citac["ocena"],
            //    EvidencijaPregleda = new EvidencijaPregleda
            //    {
            //        IdEvidencijaPregleda = (int)citac["idEvidencijaPregleda"],
            //        DatumUpisa = (DateOnly)citac["datumUpisa"],
            //        DatumZavrsavanja = (DateOnly)citac["datumZavrsavanja"],
            //    },

            //    Tretman = new Tretman
            //    {
            //        IdTretman = (int)citac["idTretman"],
            //        Naziv = (string)citac["naziv"],
            //        Trajanje = (int)citac["trajanje"],
            //        Cena = (int)citac["cena"],
            //    }
            //};
            StavkaEvidencijePregleda st = new StavkaEvidencijePregleda
            {
                Rb = (int)citac["rb"],
                IdEvidencijaPregleda = (int)citac["idEvidencijaPregleda"],
                VrednostStavke = (int)citac["vrednostStavke"],
                Napomena = (string)citac["napomena"],
                Tretman = new Tretman
                {
                    IdTretman = (int)citac["idTretman"],
                    Naziv = (string)citac["naziv"],
                    Trajanje = (int)citac["trajanje"],
                    Cena = (int)citac["cena"]
                }
            };
            return st;
        }



    }
}
