using Lab5.Controllers;
using Lab5.Interfaces;
using Lab5.Models.Individual;
using Lab5.Utils;
using Lab5.Views;
using System.Collections.Generic;

namespace Lab5
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
