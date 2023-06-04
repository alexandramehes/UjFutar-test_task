using UjFutar.EsemenyTar.Api;

namespace UjFutar.Repository.DomainEvent
{
    public record AtveteliIgenytRogzitDomainEvent : Esemeny
    {
        public int CsomagId { get; init; }
    }
}
