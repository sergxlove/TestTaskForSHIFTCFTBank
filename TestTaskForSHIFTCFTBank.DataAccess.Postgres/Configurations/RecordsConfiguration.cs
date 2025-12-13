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
            builder.HasKey(a => a.ID);
            builder.HasOne(a => a.AccountsRef)
                .WithMany(a => a.RecordsRef)
                .HasForeignKey(a => a.ACC_REF);
        }
    }
}
