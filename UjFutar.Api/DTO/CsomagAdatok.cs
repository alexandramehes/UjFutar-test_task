using System.ComponentModel.DataAnnotations.Schema;

namespace UjFutar.Api.DTO;

public class CsomagAdatok
{
    public int CsomagId { get; private set; }
    public AllapotEnum Allapot { get; private set; }
    public string AktualisPozicio { get; private set; }
    public string? JarmuRendszam { get; private set; }

    public virtual SzallitasiAdatok SzallitasiAdatok { get; private set; }

    public CsomagAdatok(int csomagId, AllapotEnum allapot, string aktualisPozicio,
        string jarmuRendszam = "")
    {
        CsomagId = csomagId;
        Allapot = allapot;
        AktualisPozicio = aktualisPozicio;
        JarmuRendszam = jarmuRendszam;
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