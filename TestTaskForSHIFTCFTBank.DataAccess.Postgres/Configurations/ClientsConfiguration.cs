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
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .HasMaxLength(1000);
            builder.Property(a => a.Place_of_birth)
                .HasMaxLength(1000);
            builder.Property(a => a.Address)
                .HasMaxLength(1000);
            builder.Property(a => a.Passport)
                .HasMaxLength(100);
            builder.HasMany(a => a.AccountsRef)
                .WithOne(a => a.ClientsRef)
                .HasForeignKey(a => a.Client_ref);
            builder.HasMany(a => a.ProductsRef)
                .WithOne(a => a.ClientsRef)
                .HasForeignKey(a => a.Client_ref);
        }
    }
}
