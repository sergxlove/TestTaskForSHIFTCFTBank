using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Configurations
{
    public class ClientsConfiguration : IEntityTypeConfiguration<ClientsEntity>
    {
        public void Configure(EntityTypeBuilder<ClientsEntity> builder)
        {
            builder.ToTable("clients");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.NAME)
                .HasMaxLength(1000);
            builder.Property(a => a.PLACE_OF_BIRTH)
                .HasMaxLength(1000);
            builder.Property(a => a.ADDRESS)
                .HasMaxLength(1000);
            builder.Property(a => a.PASSSPORT)
                .HasMaxLength(100);
            builder.HasMany(a => a.AccountsRef)
                .WithOne(a => a.ClientsRef)
                .HasForeignKey(a => a.CLIENT_REF);
            builder.HasMany(a => a.ProductsRef)
                .WithOne(a => a.ClientsRef)
                .HasForeignKey(a => a.CLIENT_REF);
        }
    }
}
