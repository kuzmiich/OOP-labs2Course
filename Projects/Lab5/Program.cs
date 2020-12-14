﻿using Lab6.Controllers;
using Lab6.Interfaces;
using Lab6.Models.Task_A;
using Lab6.Models.Task_B;
using Lab6.Models.Task_C;
using Lab6.Models.Task_D;
using Lab6.Models.Task_E;
using Lab6.Utils;
using Lab6.Views;
using System.Collections.Generic;

namespace Lab6
{
    public static class Program
    {
        private static readonly IInputService _inputService = InputService.GetInstance();
        private static readonly IOutputService _outputService = OutputService.GetInstance();
        private static MainController MainController { get; set; }

        public static void Main()
        {
            List<ITaskResult> tasks = new ()
            {
                new TaskA5(),
                new TaskB5(),
                new TaskC1(),
                new TaskD2(),
                new TaskE1(),
                new TaskA2(),
                new TaskC2(),
                new TaskB1(),
                new TaskD1(),
                new TaskE2()
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