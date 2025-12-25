using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Models;

namespace TestTaskForSHIFTCFTBank.CommandHandlers
{
    public class InterfaceHandler
    {
        private readonly IExecuteTaskRepository _repository;
        public InterfaceHandler(IExecuteTaskRepository repository)
        {
            _repository = repository;
        }
        public async Task StartExecuteAsync(CancellationToken token)
        {
            string command;
            bool isExit = false;
            while(!isExit)
            {
                Console.Write("USER > ");
                command = Console.ReadLine()!;
                switch (command)
                {
                    case "field":
                        break;
                    case "delete":
                        break;
                    case "taskThree":
                        IEnumerable<AccountsEntity> result = await _repository.ExecuteTaskThreeAsync(token);
                        foreach(AccountsEntity a in result)
                        {
                            Console.WriteLine(a);
                        }
                        break;
                    case "taskFour":
                        break;
                    case "taskFive":
                        break;
                    case "taskSix":
                        break;
                    case "taskSeven":
                        break;
                    case "taskEight":
                        break;
                    case "taskNine":
                        break;
                    case "taskTen":
                        break;
                    case "exit":
                        isExit = true;
                        break;
                    case "help":
                        Console.WriteLine("Доступные команды:");
                        Console.WriteLine("delete - \n " +
                            "exit - \n" +
                            "field - \n" +
                            "help - \n" +
                            "taskThree - \n" +
                            "taskFour - \n" +
                            "taskFive - \n" +
                            "taskSix - \n" +
                            "taskSeven - \n" +
                            "taskEight - \n" +
                            "taskNine - \n" +
                            "taskTen - \n\n");
                        break;
                }
            }
        }
    }
}
