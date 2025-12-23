namespace TestTaskForSHIFTCFTBank.CommandHandlers
{
    public class InterfaceHandler
    {
        public Task StartExecuteAsync()
        {
            string command;
            bool isExit = false;
            while(!isExit)
            {
                Console.Write("USER > ");
                command = Console.ReadLine()!;
                switch (command)
                {
                    case "exit":
                        isExit = true;
                        break;
                    case "help":
                        break;
                }
            }
            
            return Task.CompletedTask; 
        }
    }
}
