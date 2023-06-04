using UjFutar.Api.Models;

namespace UjFutar.Repository.Interface
{
    public interface ISzallitasiAdatokRepository
    {
        Task<IEnumerable<SzallitasiAdatok>> GetSzallitasiAdatokList();
        Task<SzallitasiAdatok> GetSzallitasiAdatok(int id);
        Task<SzallitasiAdatok> AddSzallitasiAdatok(SzallitasiAdatok szallitasiAdatok);
    }
}
