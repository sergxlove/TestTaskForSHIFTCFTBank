using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions;
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
    }
}
