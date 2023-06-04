using UjFutar.EsemenyTar.Api;

namespace UjFutar.Repository.DomainEvent
{
    public record SzallitasiAdatokatRogzitDomainEvent : Esemeny
    {
        public int CsomagId { get; init; }
    }
}