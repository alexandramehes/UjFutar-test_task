namespace UjFutar.WebAPI.DTO
{
    public class SzallitasiAdatokDTO
    {
        public int Id { get; private set; }
        public int CsomagAdatokId { get; private set; }
        public int FeladoId { get; private set; }
        public int CimzettId { get; private set; }

        public SzallitasiAdatokDTO(int csomagAdatokId, int feladoId, int cimzettId)
        {
            CsomagAdatokId = csomagAdatokId;
            FeladoId = feladoId;
            CimzettId = cimzettId;
        }
    }
}
