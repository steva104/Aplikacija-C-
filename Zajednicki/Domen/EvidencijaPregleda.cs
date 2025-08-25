using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class EvidencijaPregleda : IEntity
    {
        public int IdEvidencijaPregleda { get; set; }
        public DateOnly DatumPregleda { get; set; }
       
        public int UkupnaCena {  get; set; }

        public TimeSpan VremePocetka { get; set; }
        public TimeSpan VremeZavrsetka {  get; set; }
        public Zubar Zubar { get; set; }
        public Pacijent Pacijent { get; set; }

        public string ZubarFullName => Zubar.FullName;
        public string PacijentFullName => Pacijent.FullName;

        public List<StavkaEvidencijePregleda> Stavke { get; set; }

        public List<StavkaEvidencijePregleda> StavkeZaBrisanje { get; set; }
        public string NazivTabele => "EvidencijaPregleda";

        public string Vrednosti => $"('{DatumPregleda}','{VremePocetka}','{VremeZavrsetka}',{UkupnaCena},{Zubar.IdZubar},{Pacijent.IdPacijent})";

        public string Uslov => $"idEvidencijaPregleda={IdEvidencijaPregleda}";

        public string Output => "idEvidencijaPregleda";

        public string Kriterijum => " z.ime+' '+z.prezime like";

        public string JoinUslov => "ep join Zubar z on (ep.idZubar=z.idZubar) join Pacijent p on (ep.idPacijent=p.idPacijent)";

        public string UpdateUslov => $" datumPregleda='{DatumPregleda}',vremePocetka='{VremePocetka}', vremeZavrsetka='{VremeZavrsetka}', ukupnaCena={UkupnaCena}, idZubar={Zubar?.IdZubar}, idPacijent={Pacijent?.IdPacijent} ";

        public string UslovBezAlijasa => $"idEvidencijaPregleda={IdEvidencijaPregleda}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            EvidencijaPregleda p = new EvidencijaPregleda
            {
                IdEvidencijaPregleda = (int)citac["idEvidencijaPregleda"],
                DatumPregleda = DateOnly.FromDateTime((DateTime)citac["datumPregleda"]),
                VremePocetka = (TimeSpan)citac["vremePocetka"],
                VremeZavrsetka = (TimeSpan)citac["vremeZavrsetka"],
                UkupnaCena = (int)citac["ukupnaCena"],
                Zubar = new Zubar
                {
                    IdZubar = (int)citac["idZubar"],
                    KorisnickoIme = (string)citac["korisnickoIme"],
                    Sifra = (string)citac["sifra"],
                    Ime = (string)citac["ime"],
                    Prezime = (string)citac["prezime"],
                    Email = (string)citac["email"]
                },
                Pacijent = new Pacijent
                {
                    IdPacijent = (int)citac["idPacijent"],
                    Ime = (string)citac["imePacijent"],
                    Prezime = (string)citac["prezimePacijent"],
                    Email = (string)citac["emailPacijent"]
                }
            };

            return p;

        }



    }
}
