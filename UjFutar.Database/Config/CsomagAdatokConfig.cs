using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UjFutar.Api.DTO;

namespace UjFutar.Database.Config
{
    public class CsomagAdatokConfig : IEntityTypeConfiguration<CsomagAdatok>
    {
        public void Configure(EntityTypeBuilder<CsomagAdatok> builder)
        {
            builder.HasKey(e => e.CsomagId);

            builder.HasOne(e => e.SzallitasiAdatok)
                    .WithOne(e => e.CsomagAdatok)
                    .HasForeignKey<SzallitasiAdatok>(e => e.CsomagAdatokId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

            builder.Property(s => s.Allapot)
                .IsRequired();

            builder.Property(s => s.AktualisPozicio)
                .IsRequired();

            builder.Property(s => s.JarmuRendszam)
               .IsRequired();
        }
    }
}