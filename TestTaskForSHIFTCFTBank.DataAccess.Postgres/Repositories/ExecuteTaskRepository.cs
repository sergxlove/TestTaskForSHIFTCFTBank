using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using TestTaskForSHIFTCFTBank.Core.Models;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Responses;
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

        public async Task<List<Accounts>> ExecuteTaskThreeAsync(CancellationToken token)
        {
            IEnumerable<AccountsEntity> resultEntity = await _dapperWorks.QueryDapperAsync<AccountsEntity>
                (_context, SelectDataScripts.ScriptTaskThree(), token);
            List<Accounts> result = new();
            foreach (AccountsEntity a in resultEntity)
            {
                Accounts acc = new()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Saldo = a.Saldo,
                    Client_ref = a.Client_ref,
                    Open_date = a.Open_date,
                    Close_date = a.Close_date,
                    Product_ref = a.Product_ref,
                    Acc_num = a.Acc_num
                };
                result.Add(acc);
            }
            return result;
        }

        public async Task<List<Accounts>> ExecuteTaskFourAsync(CancellationToken token)
        {
            IEnumerable<AccountsEntity> resultEntity = await _dapperWorks.QueryDapperAsync<AccountsEntity>
                (_context, SelectDataScripts.ScriptTaskFour(), token);
            List<Accounts> result = new();
            foreach (AccountsEntity a in resultEntity)
            {
                Accounts acc = new()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Saldo = a.Saldo,
                    Client_ref = a.Client_ref,
                    Open_date = a.Open_date,
                    Close_date = a.Close_date,
                    Product_ref = a.Product_ref,
                    Acc_num = a.Acc_num
                };
                result.Add(acc);
            }
            return result;
        }

        public async Task<List<Clients>> ExecuteTaskFiveAsync(CancellationToken token)
        {
            IEnumerable<ClientsEntity> resultEntity = await _dapperWorks.QueryDapperAsync<ClientsEntity>
                (_context, SelectDataScripts.ScriptTaskFive(), token);
            List<Clients> result = new();
            foreach (ClientsEntity c in resultEntity)
            {
                Clients client = new()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Address = c.Address,
                    Date_of_birth = c.Date_of_birth,
                    Place_of_birth = c.Place_of_birth,
                    Passport = c.Passport
                };
                result.Add(client);
            }
            return result;
        }

        public async Task<int> ExecuteTaskSixAsync(CancellationToken token)
        {
            DbConnection connection = _context.Database.GetDbConnection();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    IEnumerable<SaldoResponse> saldoUser = await _dapperWorks.QueryDapperAsync<SaldoResponse>
                    (_context, UpdateDataScripts.ScriptTaskSixPart1(), token);
                    int result = 0;
                    foreach (SaldoResponse s in saldoUser)
                    {
                        if (s.Saldo != s.Current)
                        {
                            result += await _dapperWorks.ExecuteDapperAsync(_context, UpdateDataScripts
                                .ScriptTaskSixPart2(Convert.ToString(s.Current * 1.01m), s.Id.ToString()),
                                token);
                        }
                    }
                    transaction.Commit();
                    return result;
                }
                catch 
                {
                    transaction.Rollback();
                    return 0;
                }
            }
        }
    }
}
