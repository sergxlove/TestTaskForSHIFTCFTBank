using TestTaskForSHIFTCFTBank.Core.Models;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Scripts;

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Repositories
{
    public class ExecuteTaskRepository : IExecuteTaskRepository
    {
        private readonly IDapperWorks _dapperWorks;
        private readonly BankContext _context;
        public ExecuteTaskRepository(IDapperWorks dapperWorks, BankContext context)
        {
            _dapperWorks = dapperWorks;
            _context = context;
        }

        public async Task<int> FieldAllTableAsync(CancellationToken token)
        {
            return await _dapperWorks.ExecuteDapperAsync(_context, FieldTableScripts.FieldAll(),
                token);
        }

        public async Task<int> DeleteDataAllTableAsync(CancellationToken token)
        {
            return await _dapperWorks.ExecuteDapperAsync(_context, DeleteDataTableScripts.DeleteAll(),
                token);
        }

        public async Task<IEnumerable<AccountsEntity>> ExecuteTaskThreeAsync(CancellationToken token)
        {
            return await _dapperWorks.QueryDapperAsync<AccountsEntity>
                (_context, SelectDataScripts.ScriptTaskThree(), token);
        } 

    }
}
