using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Infrastructures
{
    public class DapperWorks : IDapperWorks
    {
        public async Task<int> ExecuteDapperAsync(BankContext context, string sqlQuery,
            CancellationToken token)
        {
            DbConnection connection = context.Database.GetDbConnection();
            if (connection.State != ConnectionState.Open)
                await connection.OpenAsync();
            return await connection.ExecuteAsync(sqlQuery, token);
        }

        public async Task<IEnumerable<T>> QueryDapperAsync<T>(BankContext context, string sqlQuery,
            CancellationToken token)
        {
            DbConnection connection = context.Database.GetDbConnection();
            if (connection.State != ConnectionState.Open)
                await connection.OpenAsync();
            return await connection.QueryAsync<T>(sqlQuery, token);
        }
    }
}
