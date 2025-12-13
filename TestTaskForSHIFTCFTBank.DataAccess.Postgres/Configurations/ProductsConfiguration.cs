using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<ProductsEntity>
    {
        public void Configure(EntityTypeBuilder<ProductsEntity> builder)
        {
            builder.ToTable("products");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.NAME)
                .HasMaxLength(100);
            builder.HasMany(a => a.AccountsRef)
                .WithOne(a => a.ProductsRef)
                .HasForeignKey(a => a.PRODUCT_REF);
            builder.HasOne(a => a.ProductsTypeRef)
                .WithMany(a => a.ProductsRef)
                .HasForeignKey(a => a.PRODUCTS_TYPE_ID);
            builder.HasOne(a => a.ClientsRef)
                .WithMany(a => a.ProductsRef)
                .HasForeignKey(a => a.CLIENT_REF);
        }
    }
}
