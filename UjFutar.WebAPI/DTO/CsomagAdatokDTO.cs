namespace UjFutar.WebAPI.DTO
{
    public class CsomagAdatokDTO
    {
        public int CsomagId { get; private set; }
        public AllapotEnum Allapot { get; private set; }
        public string AktualisPozicio { get; private set; }
        public string? JarmuRendszam { get; private set; }

        public CsomagAdatokDTO(int csomagId, string aktualisPozicio,
            string jarmuRendszam = "")
        {
            CsomagId = csomagId;
            AktualisPozicio = aktualisPozicio;
            JarmuRendszam = jarmuRendszam;
        }

        public enum AllapotEnum
        {
            FelvetelreVar,
            SzallitasAlatt,
            AtvetelreVar,
            KezbesitesAlatt,
            Kezbesitve
        }
    }
}
