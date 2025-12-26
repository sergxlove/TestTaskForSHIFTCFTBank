using TestTaskForSHIFTCFTBank.Core.Models;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Responses;
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
        Task<List<ProductResponse>> ExecuteTaskSevenAsync(CancellationToken token);
        Task<int> ExecuteTaskEightAsync(CancellationToken token);
        Task<int> ExecuteTaskNineAsync(CancellationToken token);

    }
}