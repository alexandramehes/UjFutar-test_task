namespace UjFutar.Api.DTO;

public class SzallitasiAdatok
{
    public int Id { get; private set; }
    public int CsomagAdatokId { get; private set; }
    public int FeladoId { get; private set; }
    public int CimzettId { get; private set; }

    public CsomagAdatok CsomagAdatok { get; private set; }
    public Szemely Felado { get; private set; }
    public Szemely Cimzett { get; private set; }

    public SzallitasiAdatok(int csomagAdatokId, int feladoId, int cimzettId)
    {
        CsomagAdatokId = csomagAdatokId;
        FeladoId = feladoId;
        CimzettId = cimzettId;
    }
}