using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Zubar : IEntity
    {
        public int IdZubar { get; set; }
        public string KorisnickoIme { get; set; }

        public string Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        public string FullName
        {
            get { return Ime + " " + Prezime; }
        }
        public string NazivTabele => "Zubar";

        public string Vrednosti => $"{Ime},{Prezime}";

        public string Uslov => $"korisnickoIme='{KorisnickoIme}' and sifra='{Sifra}'";

        public string Output => "idZubar";

        public string Kriterijum => "";

        public string JoinUslov => "";

        public string UpdateUslov => "";

        public string UslovBezAlijasa => $"korisnickoIme='{KorisnickoIme}' and sifra='{Sifra}'";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            Zubar z = new Zubar
            {
                IdZubar = (int)citac["idZubar"],
                Ime = (string)citac["ime"],
                Prezime = (string)citac["prezime"],
                Email = (string)citac["email"],
                KorisnickoIme = (string)citac["korisnickoIme"],
                Sifra = (string)citac["sifra"]
            };
            return z;
        }
    }
}
