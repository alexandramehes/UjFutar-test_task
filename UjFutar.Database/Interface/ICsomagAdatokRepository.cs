using UjFutar.Api.Models;

namespace UjFutar.Repository.Interface
{
    public interface ICsomagAdatokRepository
    {
        Task<IEnumerable<CsomagAdatok>> GetCsomagAdatokList();
        Task<CsomagAdatok> GetCsomagAdatok(int id);
        Task<CsomagAdatok> AddCsomagAdatok(CsomagAdatok csomagAdatok);
    }
}
