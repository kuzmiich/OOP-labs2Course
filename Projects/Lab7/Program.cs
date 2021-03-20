using Lab7.Controller;
using Lab7.InputService.ConsoleInput;
using Lab7.OutputService.ConsoleOutput;

namespace Lab7
{
    public class Program
    {
        private static readonly IConsoleInput _inputService = ConsoleInput.GetInstance();
        private static readonly IConsoleOutput _outputService = ConsoleOutput.GetInstance();
        private static MainController MainController { get; set; }

        static void Main(string[] args)
        {
            
        }
    }
}
