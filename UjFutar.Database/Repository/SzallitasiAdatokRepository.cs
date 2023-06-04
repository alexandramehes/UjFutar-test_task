using Microsoft.EntityFrameworkCore;
using UjFutar.Api.Models;
using UjFutar.Database;
using UjFutar.Repository.Interface;

namespace UjFutar.Repository.Repository
{
    public class SzallitasiAdatokRepository : ISzallitasiAdatokRepository
    {
        private readonly UjFutarContext context;

        public SzallitasiAdatokRepository(UjFutarContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<SzallitasiAdatok>> GetSzallitasiAdatokList()
        {
            return await context.SzallitasiAdatok.ToListAsync();
        }

        public async Task<SzallitasiAdatok> GetSzallitasiAdatok(int id)
        {
            return await context.SzallitasiAdatok
                .FirstOrDefaultAsync(e => e.CsomagAdatokId == id);
        }

        public async Task<SzallitasiAdatok> AddSzallitasiAdatok(SzallitasiAdatok szallitasiAdatok)
        {
            var result = await context.SzallitasiAdatok.AddAsync(szallitasiAdatok);
            await context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
