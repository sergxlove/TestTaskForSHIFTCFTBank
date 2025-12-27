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
                    Date_of_birth = DateOnly.FromDateTime(c.Date_of_birth),
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
            using var transaction = connection.BeginTransaction();
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

        public async Task<List<ProductResponse>> ExecuteTaskSevenAsync(CancellationToken token)
        {
            IEnumerable<ProductResponse> result = await _dapperWorks.QueryDapperAsync<ProductResponse>
                (_context, SelectDataScripts.ScriptTaskSeven(), token);
            List<ProductResponse> resultList = new(result);
            return resultList;
        }

        public async Task<int> ExecuteTaskEightAsync(CancellationToken token)
        {
            DbConnection connection = _context.Database.GetDbConnection();
            using var transaction = connection.BeginTransaction();
            try
            {
                IEnumerable<int> idProducts = await _dapperWorks.QueryDapperAsync<int>(_context,
                    UpdateDataScripts.ScriptTaskEightPart1(), token);
                int result = 0;
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                string dateString = currentDate.Year + "-" + currentDate.Month + "-" + currentDate.Day;
                foreach(int p  in idProducts)
                {
                    result += await _dapperWorks.ExecuteDapperAsync(_context, 
                        UpdateDataScripts.ScriptTaskEightPart2(currentDate.ToString(), p.ToString()), 
                        token);
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

        public async Task<int> ExecuteTaskNineAsync(CancellationToken token)
        {
            DbConnection connection = _context.Database.GetDbConnection();
            using var transaction = connection.BeginTransaction();
            try
            {
                IEnumerable<ClientCountResponse> clientsId = await _dapperWorks
                    .QueryDapperAsync<ClientCountResponse>
                    (_context, UpdateDataScripts.ScriptTaskNinePart1(), token);
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                string dateString = currentDate.Year + "-" + currentDate.Month + "-" + currentDate.Day;
                int result = 0;
                int middleResult = 0;
                decimal newSaldo;
                IEnumerable<ClientAccResponse> idFirstAcc;
                IEnumerable<ClientAccResponse> idSecondAcc;
                foreach(ClientCountResponse c in clientsId)
                {
                    idFirstAcc = await _dapperWorks.QueryDapperAsync<ClientAccResponse>(_context,
                        UpdateDataScripts.ScriptTaskNinePart2(c.Id.ToString()), token);
                    idSecondAcc = await _dapperWorks.QueryDapperAsync<ClientAccResponse>(_context,
                        UpdateDataScripts.ScriptTaskNinePart3(c.Id.ToString()), token);
                    newSaldo = idFirstAcc.ElementAt(0).Saldo + idSecondAcc.ElementAt(0).Saldo;
                    middleResult = await _dapperWorks.ExecuteDapperAsync(_context,
                        UpdateDataScripts.ScriptTaskNinePart4(idSecondAcc.ElementAt(0).Id.ToString(),
                        newSaldo.ToString()), token);
                    if (middleResult == 0) throw new Exception();
                    result += await _dapperWorks.ExecuteDapperAsync(_context,
                        UpdateDataScripts.ScriptTaskNinePart5(idFirstAcc.ElementAt(0).Id.ToString(),
                        dateString), token);
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

        public async Task<int> ExecuteTaskTenAsync(CancellationToken token)
        {
            DbConnection connection = _context.Database.GetDbConnection();
            using var transaction = connection.BeginTransaction();
            try
            {
                int result = 0;
                await _dapperWorks.ExecuteDapperAsync(_context, UpdateDataScripts.ScriptsTaskTenPart1(),
                    token);
                result += await _dapperWorks.ExecuteDapperAsync(_context, 
                    UpdateDataScripts.ScriptsTaskTenPart2(), token);
                result += await _dapperWorks.ExecuteDapperAsync(_context,
                    UpdateDataScripts.ScriptsTaskTenPart3(), token);
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
