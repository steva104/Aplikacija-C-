using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Pacijent : IEntity
    {

        public int IdPacijent { get; set; }
        public string FullName
        {
            get { return Ime + " " + Prezime; }
        }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona {  get; set; }
        public string Email { get; set; }
        public string MestoPrebivalista => Mesto?.Naziv + " - " + Mesto?.Ptt;
        public Mesto Mesto { get; set; }

        

        public string NazivTabele => "Pacijent";

        public string Vrednosti => $"('{Ime}','{Prezime}','{BrojTelefona}','{Email}',{Mesto?.IdMesto})";

        public string Uslov => $"idPacijent={IdPacijent}";

        public string Output => "idPacijent";

        public string Kriterijum => " p.imePacijent+' '+p.prezimePacijent like";

        public string JoinUslov => "p join Mesto m on (p.idMesto=m.idMesto)";

        public string UpdateUslov => $"imePacijent='{Ime}',prezimePacijent='{Prezime}',brojTelefona='{BrojTelefona}',emailPacijent='{Email}', idMesto={Mesto?.IdMesto}";

        public string UslovBezAlijasa => $"idPacijent={IdPacijent}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            Pacijent p= new Pacijent
            {
                IdPacijent = (int)citac["idPacijent"],
                Ime = (string)citac["imePacijent"],
                Prezime = (string)citac["prezimePacijent"],
                BrojTelefona = (string)citac["brojTelefona"],
                Email = (string)citac["emailPacijent"],
                Mesto = new Mesto
                {
                    IdMesto = (int)citac["idMesto"],
                    Naziv = (string)citac["naziv"],
                    Ptt = (int)citac["ptt"]
                }
            };
            return p;
        }

    }
}
