using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestTaskForSHIFTCFTBank.CommandHandlers;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Infrastructures;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Repositories;

namespace TestTaskForSHIFTCFTBank
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new();
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<BankContext>(options => 
                options.UseNpgsql("User ID=postgres;Password=123;Host=localhost;Port=5432;Database=db;"));
            serviceCollection.AddScoped<IDapperWorks, DapperWorks>();
            serviceCollection.AddScoped<IExecuteTaskRepository, ExecuteTaskRepository>();
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            IExecuteTaskRepository rep = serviceProvider.GetService<IExecuteTaskRepository>()!;
            InterfaceHandler handler = new(rep);
            await handler.StartExecuteAsync(cts.Token);
        }
    }
}
