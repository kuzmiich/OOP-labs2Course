using Lab7.Controllers;
using Lab7.Views;
using Lab7.Models.Individual;
using Lab7.Utils;
using Lab7.Views;
using System.Collections.Generic;

namespace Lab7
{
    public static class Program
    {
        private static readonly IInputService _inputService = InputService.GetInstance();
        private static readonly IOutputService _outputService = OutputService.GetInstance();
        private static MainController MainController { get; set; }

        public static void Main()
        {
            List<ITaskResult> tasks = new()
            {
                new TaskIndividual1(),
                new TaskIndividual2(),
            };
            MainController = new MainController
            (
                tasks,
                _inputService,
                _outputService
            );
            MainController.StartController();
        }
    }
}
