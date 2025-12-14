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

            builder.Property(a => a.Id)
                .HasColumnName("id");
            builder.Property(a => a.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            builder.Property(a => a.Begin_date)
                .HasColumnName("begin_date");
            builder.Property(a => a.End_date)
                .HasColumnName("end_date");
            builder.Property(a => a.Tarif_ref)
                .HasColumnName("tarif_ref");

            builder.HasOne(a => a.TarifsRef)
                .WithMany(a => a.ProductTypesRef)
                .HasForeignKey(a => a.Tarif_ref);
            builder.HasMany(a => a.ProductsRef)
                .WithOne(a => a.ProductsTypeRef)
                .HasForeignKey(a => a.Products_type_id);
        }
    }
}
