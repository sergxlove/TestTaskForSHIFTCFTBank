using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Configurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductTypeEntity>
    {
        public void Configure(EntityTypeBuilder<ProductTypeEntity> builder)
        {
            builder.ToTable("productype");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .HasMaxLength(100);
            builder.HasOne(a => a.TarifsRef)
                .WithMany(a => a.ProductTypesRef)
                .HasForeignKey(a => a.Tarif_ref);
            builder.HasMany(a => a.ProductsRef)
                .WithOne(a => a.ProductsTypeRef)
                .HasForeignKey(a => a.Products_type_id);
        }
    }
}
