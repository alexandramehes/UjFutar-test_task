using UjFutar.EsemenyTar.Api;

namespace UjFutar.Repository.DomainEvent
{
    public record CsomagotFelveszDomainEvent : Esemeny
    {
        public int CsomagId { get; init; }
    }
}
