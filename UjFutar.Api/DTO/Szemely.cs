namespace UjFutar.Api.DTO
{
    public class Szemely
    {
        public int Id { get; private set; }
        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public string Email { get; private set; }

        public virtual SzallitasiAdatok? SzallitasiAdatok { get; private set; }

        public Szemely(int id, string nev, string cim, string email)
        {
            Id = id;
            Nev = nev;
            Cim = cim;
            Email = email;
        }
    }
}