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

            builder.Property(a => a.Id)
                .HasColumnName("id");
            builder.Property(a => a.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            builder.Property(a => a.Saldo)
                .HasColumnName("saldo");
            builder.Property(a => a.Client_ref)
                .HasColumnName("client_ref");
            builder.Property(a => a.Open_date)
                .HasColumnName("open_date");
            builder.Property(a => a.Close_date)
                .HasColumnName("close_date");
            builder.Property(a => a.Product_ref)
                .HasColumnName("product_ref");
            builder.Property(a => a.Acc_num)
                .HasMaxLength(25)
                .HasColumnName("acc_num");

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
