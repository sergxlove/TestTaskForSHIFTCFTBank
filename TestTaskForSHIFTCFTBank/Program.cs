using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres;

namespace TestTaskForSHIFTCFTBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<BankContext>();
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
