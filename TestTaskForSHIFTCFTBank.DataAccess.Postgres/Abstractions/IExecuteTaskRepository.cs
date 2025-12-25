using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions
{
    public interface IExecuteTaskRepository
    {
        Task<int> FieldAllTableAsync(CancellationToken token);
        Task<int> DeleteDataAllTableAsync(CancellationToken token);
        Task<IEnumerable<AccountsEntity>> ExecuteTaskThreeAsync(CancellationToken token);
    }
}