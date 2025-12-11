using Microsoft.EntityFrameworkCore;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
            
        }

        public DbSet<AccountsEntity> AccountsTable { get; set; }
        public DbSet<ClientsEntity> ClientsTable { get; set; }
        public DbSet<ProductsEntity> ProductsTable { get; set; }
        public DbSet<ProductTypeEntity> ProductTypeTable { get; set; }
        public DbSet<RecordsEntity> RecordsTable { get; set; }
        public DbSet<TarifsEntity> TarifsTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
