using UjFutar.EsemenyTar.Api;

namespace UjFutar.MemoryEsemenyTar.Unit;

//Nem módosítható
public record OklevelKiallitva : Esemeny
{
    public string Nev { get; init; }
    public DateTime Idopont { get; init; }
    public string Telepules { get; init; }
}