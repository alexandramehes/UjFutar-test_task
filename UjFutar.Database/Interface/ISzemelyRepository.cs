using UjFutar.Api.Models;

namespace UjFutar.Repository.Interface
{
    public interface ISzemelyRepository
    {
        Task<IEnumerable<Szemely>> GetSzemelyList();
        Task<Szemely> GetSzemely(int id);
        Task<Szemely> AddSzemely(Szemely szemely);
    }
}
