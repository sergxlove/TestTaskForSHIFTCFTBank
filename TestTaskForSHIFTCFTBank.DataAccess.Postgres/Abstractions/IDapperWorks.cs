namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions
{
    public interface IDapperWorks
    {
        Task<int> ExecuteDapperAsync(BankContext context, string sqlQuery, CancellationToken token);
        Task<IEnumerable<T>> QueryDapperAsync<T>(BankContext context, string sqlQuery, CancellationToken token);
    }
}