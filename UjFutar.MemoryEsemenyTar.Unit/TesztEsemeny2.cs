using UjFutar.EsemenyTar.Api;

namespace UjFutar.MemoryEsemenyTar.Unit;

//Nem módosítható
public record TesztEsemeny2 : Esemeny
{
    public string Tartalom { get; init; }
}
