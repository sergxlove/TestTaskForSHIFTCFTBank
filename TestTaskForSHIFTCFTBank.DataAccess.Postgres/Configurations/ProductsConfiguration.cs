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
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .HasMaxLength(100);
            builder.HasMany(a => a.AccountsRef)
                .WithOne(a => a.ProductsRef)
                .HasForeignKey(a => a.Product_ref);
            builder.HasOne(a => a.ProductsTypeRef)
                .WithMany(a => a.ProductsRef)
                .HasForeignKey(a => a.Products_type_id);
            builder.HasOne(a => a.ClientsRef)
                .WithMany(a => a.ProductsRef)
                .HasForeignKey(a => a.Client_ref);
        }
    }
}
