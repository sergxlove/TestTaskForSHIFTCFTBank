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
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .HasMaxLength(100);
            builder.Property(a => a.Acc_num)
                .HasMaxLength(25);
            builder.HasMany(a => a.RecordsRef)
                .WithOne(a => a.AccountsRef)
                .HasForeignKey(a => a.Acc_ref);
            builder.HasOne(a => a.ClientsRef)
                .WithMany(a => a.AccountsRef)
                .HasForeignKey(a => a.Client_ref);
            builder.HasOne(a => a.ProductsRef)
                .WithMany(a => a.AccountsRef)
                .HasForeignKey(a => a.Product_ref);
        }
    }
}
