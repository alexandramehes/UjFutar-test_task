namespace UjFutar.Api.Models;

public class CsomagAdatok
{
    public int CsomagId { get; private set; }
    public AllapotEnum Allapot { get; private set; }
    public string AktualisPozicio { get; private set; }
    public string? JarmuRendszam { get; private set; }

    public virtual SzallitasiAdatok SzallitasiAdatok { get; private set; }

    public CsomagAdatok(int csomagId, string aktualisPozicio, string jarmuRendszam = "")
    {
        CsomagId = csomagId;
        AktualisPozicio = aktualisPozicio;
        JarmuRendszam = jarmuRendszam;
    }

    public void SetAllapot(string allapot)
    {
        if (Enum.TryParse<AllapotEnum>(allapot, out var parsedAllapot))
        {
            Allapot = parsedAllapot;
        }
        else
        {
            throw new ArgumentException("Invalid value");
        }
    }

    public enum AllapotEnum
    {
        Ures,
        FelvetelreVar,
        SzallitasAlatt,
        AtvetelreVar,
        KezbesitesAlatt,
        Kezbesitve
    }
}