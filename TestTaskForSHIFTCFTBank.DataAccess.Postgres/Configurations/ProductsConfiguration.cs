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

            builder.Property(a => a.Id)
                .HasColumnName("id");
            builder.Property(a => a.Products_type_id)
                .HasColumnName("product_type_id");
            builder.Property(a => a.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            builder.Property(a => a.Client_ref)
                .HasColumnName("client_ref");
            builder.Property(a => a.Open_date)
                .HasColumnName("open_date");
            builder.Property(a => a.Close_date)
                .HasColumnName("close_date");

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
