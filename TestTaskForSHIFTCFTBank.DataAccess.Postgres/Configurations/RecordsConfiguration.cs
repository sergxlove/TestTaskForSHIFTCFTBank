using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Configurations
{
    public class RecordsConfiguration : IEntityTypeConfiguration<RecordsEntity>
    {
        public void Configure(EntityTypeBuilder<RecordsEntity> builder)
        {
            builder.ToTable("records");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .HasColumnName("id");
            builder.Property(a => a.Dt)
                .HasColumnName("dt");
            builder.Property(a => a.Sum)
                .HasColumnName("sum");
            builder.Property(a => a.Acc_ref)
                .HasColumnName("acc_ref");
            builder.Property(a => a.Oper_date)
                .HasColumnName("oper_date");

            builder.HasOne(a => a.AccountsRef)
                .WithMany(a => a.RecordsRef)
                .HasForeignKey(a => a.Acc_ref);
        }
    }
}
