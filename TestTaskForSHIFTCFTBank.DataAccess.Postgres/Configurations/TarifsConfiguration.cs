using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Configurations
{
    public class TarifsConfiguration : IEntityTypeConfiguration<TarifsEntity>
    {
        public void Configure(EntityTypeBuilder<TarifsEntity> builder)
        {
            builder.ToTable("tarifs");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .HasMaxLength(100);
            builder.HasMany(a => a.ProductTypesRef)
                .WithOne(a => a.TarifsRef)
                .HasForeignKey(a => a.Tarif_ref);
        }
    }
}
