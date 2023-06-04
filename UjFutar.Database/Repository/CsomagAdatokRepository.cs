using Microsoft.EntityFrameworkCore;
using UjFutar.Api.Models;
using UjFutar.Database;
using UjFutar.Repository.Interface;

namespace UjFutar.Repository.Repository
{
    public class CsomagAdatokRepository : ICsomagAdatokRepository
    {
        private readonly UjFutarContext context;

        public CsomagAdatokRepository(UjFutarContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<CsomagAdatok>> GetCsomagAdatokList()
        {
            return await context.CsomagAdatok.ToListAsync();
        }

        public async Task<CsomagAdatok> GetCsomagAdatok(int id)
        {
            return await context.CsomagAdatok
                .FirstOrDefaultAsync(e => e.CsomagId == id);
        }

        public async Task<CsomagAdatok> AddCsomagAdatok(CsomagAdatok csomagAdatok)
        {
            var result = await context.CsomagAdatok.AddAsync(csomagAdatok);
            await context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
