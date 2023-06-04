using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UjFutar.Api.DTO;

namespace UjFutar.Database.Config
{
    public class SzemelyConfig : IEntityTypeConfiguration<Szemely>
    {
        public void Configure(EntityTypeBuilder<Szemely> builder)
        {
            builder.Property(s => s.Id)
                .IsRequired();

            builder.Property(s => s.Nev)
                .IsRequired();

            builder.Property(s => s.Email)
                .IsRequired();

            builder.Property(s => s.Cim)
                .IsRequired();
        }
    }
}