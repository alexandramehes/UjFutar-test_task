using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UjFutar.Api.Models;

namespace UjFutar.Database.Config
{
    public class SzallitasiAdatokConfig : IEntityTypeConfiguration<SzallitasiAdatok>
    {
        public void Configure(EntityTypeBuilder<SzallitasiAdatok> builder)
        {
            builder.HasKey(e => e.CsomagAdatokId);

            builder.HasOne(e => e.Felado)
                .WithMany()
                .HasForeignKey(e => e.FeladoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Cimzett)
               .WithMany()
               .HasForeignKey(e => e.CimzettId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}