using Lab4.Model.Tasks.Base;
using Lab4.Views;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Controller
{
    sealed class MainController
    {
        public IEnumerable<ITask> Tasks { get; }
        public IInputService InputService { get; }
        public IOutputService OutputService { get; }

        public MainController(IEnumerable<ITask> tasks, IInputService inputService, IOutputService outputService)
        {
            Tasks = tasks;
            InputService = inputService;
            OutputService = outputService;
        }
    }
}