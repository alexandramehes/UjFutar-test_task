using Microsoft.EntityFrameworkCore;
using UjFutar.Api.Models;
using UjFutar.Database;
using UjFutar.Repository.Interface;

namespace UjFutar.Repository.Repository
{
    public class SzemelyRepository : ISzemelyRepository
    {
        private readonly UjFutarContext context;

        public SzemelyRepository(UjFutarContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Szemely>> GetSzemelyList()
        {
            return await context.Szemely.ToListAsync();
        }

        public async Task<Szemely> GetSzemely(int id)
        {
            return await context.Szemely
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Szemely> AddSzemely(Szemely szemely)
        {
            var result = await context.Szemely.AddAsync(szemely);
            await context.SaveChangesAsync();
            return result.Entity;
        }

    }
}
