using Lab4.Views;
using Lab4.Model.Tasks.Common;
using Lab4.Model.Tasks.Individual;
using Lab4.Model.Tasks.Additional;

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
