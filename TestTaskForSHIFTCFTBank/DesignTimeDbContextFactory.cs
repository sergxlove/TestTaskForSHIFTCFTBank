using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BankContext>
{
    public BankContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BankContext>();
        optionsBuilder.UseNpgsql(
            "User ID=postgres;Password=123;Host=localhost;Port=5432;Database=db;"
        );

        return new BankContext(optionsBuilder.Options);
    }
}