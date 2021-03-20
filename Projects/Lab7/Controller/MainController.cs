using Lab7.InputService.ConsoleInput;
using Lab7.OutputService.ConsoleOutput;
using Lab7.Utils;

namespace Lab7.Controller
{
    public class MainController
    {
        public IConsoleInput InputService { get; init; }
        public IConsoleOutput OutputService { get; init; }
        public Extractor Extractor { get; init; }

        public MainController(IConsoleInput inputService, IConsoleOutput outputService)
        {
            InputService = inputService;
            OutputService = outputService;
            Extractor = new Extractor(outputService, inputService);
        }

        public void StartController()
        {
        }
    }
}
