using TestTaskForSHIFTCFTBank.Core.Models;
using TestTaskForSHIFTCFTBank.DataAccess.Postgres.Abstractions;

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
            int result = 0;
            while(!isExit)
            {
                Console.Write("USER > ");
                command = Console.ReadLine()!;
                switch (command)
                {
                    case "field":
                        result = await _repository.FieldAllTableAsync(token);
                        Console.WriteLine($"Строк затронуло: {result}");
                        break;
                    case "delete":
                        result = await _repository.DeleteDataAllTableAsync(token);
                        Console.WriteLine($"Строк затронуло: {result}");
                        break;
                    case "3":
                    case "taskThree":
                        foreach(Accounts a in await _repository.ExecuteTaskThreeAsync(token))
                        {
                            Console.WriteLine(a);
                        }
                        break;
                    case "4":
                    case "taskFour":
                        foreach(Accounts a in await _repository.ExecuteTaskFourAsync(token))
                        {
                            Console.WriteLine(a);
                        }
                        break;
                    case "5":
                    case "taskFive":
                        foreach(Clients c in await _repository.ExecuteTaskFiveAsync(token))
                        {
                            Console.WriteLine(c);
                        }
                        break;
                    case "6":
                    case "taskSix":
                        result = await _repository.ExecuteTaskSixAsync(token);
                        Console.WriteLine($"Строк затронуло: {result}");
                        break;
                    case "7":
                    case "taskSeven":
                        break;
                    case "8":
                    case "taskEight":
                        break;
                    case "9":
                    case "taskNine":
                        break;
                    case "10":
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
                            "taskThree (3) - \n" +
                            "taskFour (4) - \n" +
                            "taskFive (5) - \n" +
                            "taskSix (6) - \n" +
                            "taskSeven (7) - \n" +
                            "taskEight (8) - \n" +
                            "taskNine (9) - \n" +
                            "taskTen (10) - \n\n");
                        break;
                }
            }
        }
    }
}
