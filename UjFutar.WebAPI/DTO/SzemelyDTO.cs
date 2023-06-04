namespace UjFutar.WebAPI.DTO
{
    public class SzemelyDTO
    {
        public int Id { get; private set; }
        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public string Email { get; private set; }

        public SzemelyDTO(int id, string nev, string cim, string email)
        {
            Id = id;
            Nev = nev;
            Cim = cim;
            Email = email;
        }
    }
}
