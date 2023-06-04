using Microsoft.EntityFrameworkCore;
using UjFutar.Api.DTO;
using UjFutar.Database.Config;

namespace UjFutar.Database
{
    public class UjFutarContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public UjFutarContext(IConfiguration configuration) => _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));

        public DbSet<CsomagAdatok> CsomagAdatok { get; set; }
        public DbSet<SzallitasiAdatok> SzallitasiAdatok { get; set; }
        public DbSet<Szemely> Szemely { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SzemelyConfig());
            builder.ApplyConfiguration(new CsomagAdatokConfig());
            builder.ApplyConfiguration(new SzallitasiAdatokConfig());

            builder.Seed();
        }
    }
}
