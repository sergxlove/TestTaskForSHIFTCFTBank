namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions
{
    public interface IExecuteTaskRepository
    {
        Task<int> FieldAllTableAsync(CancellationToken token);
    }
}