using TestTaskForSHIFTCFTBank.Core.Models;
namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions
{
    public interface IExecuteTaskRepository
    {
        Task<int> FieldAllTableAsync(CancellationToken token);
        Task<int> DeleteDataAllTableAsync(CancellationToken token);
        Task<List<Accounts>> ExecuteTaskThreeAsync(CancellationToken token);
        Task<List<Accounts>> ExecuteTaskFourAsync(CancellationToken token);
        Task<List<Clients>> ExecuteTaskFiveAsync(CancellationToken token);
        Task<int> ExecuteTaskSixAsync(CancellationToken token);
    }
}