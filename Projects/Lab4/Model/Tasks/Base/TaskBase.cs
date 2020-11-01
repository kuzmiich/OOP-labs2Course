﻿using Lab4.Views;

namespace Lab4.Model.Tasks.Base
{
    abstract class TaskBase : ITask
    {
        protected IInputService InputService{ get; set; }
        protected IOutputService OutputService { get; set; }
        public TaskBase(IInputService inputService, IOutputService outputService)
        {
            InputService = inputService;
            OutputService = outputService;
        }

        public abstract string Invoke();
    }
}
