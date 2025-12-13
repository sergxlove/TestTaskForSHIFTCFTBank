using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Configurations
{
    public class AccountsConfiguration : IEntityTypeConfiguration<AccountsEntity>
    {
        public void Configure(EntityTypeBuilder<AccountsEntity> builder)
        {
            builder.ToTable("accounts");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.NAME)
                .HasMaxLength(100);
            builder.Property(a => a.ACC_NUM)
                .HasMaxLength(25);
            builder.HasMany(a => a.RecordsRef)
                .WithOne(a => a.AccountsRef)
                .HasForeignKey(a => a.ACC_REF);
            builder.HasOne(a => a.ClientsRef)
                .WithMany(a => a.AccountsRef)
                .HasForeignKey(a => a.CLIENT_REF);
            builder.HasOne(a => a.ProductsRef)
                .WithMany(a => a.AccountsRef)
                .HasForeignKey(a => a.PRODUCT_REF);
        }
    }
}
