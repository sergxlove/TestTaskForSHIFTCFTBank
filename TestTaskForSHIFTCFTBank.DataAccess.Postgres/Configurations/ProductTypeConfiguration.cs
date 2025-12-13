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
            builder.HasKey(a => a.ID);
            builder.Property(a => a.NAME)
                .HasMaxLength(100);
            builder.HasOne(a => a.TarifsRef)
                .WithMany(a => a.ProductTypesRef)
                .HasForeignKey(a => a.TARIF_REF);
            builder.HasMany(a => a.ProductsRef)
                .WithOne(a => a.ProductsTypeRef)
                .HasForeignKey(a => a.PRODUCTS_TYPE_ID);
        }
    }
}
