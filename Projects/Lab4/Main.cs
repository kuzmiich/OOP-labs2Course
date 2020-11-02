using System;
using Lab4.Views;
using Lab4.Model.MyConverter;
using Lab4.Model.Tasks.Common;
using Lab4.Model.Tasks.Individual;
using Lab4.Model.Tasks.Additional;

namespace Lab4
{
    class Program
    {
        private static void MenuCommand()
        {
            OutputService.ShowMessage("1.Show all tasks");
            OutputService.ShowMessage("2.Choose task type.");
            OutputService.ShowMessage("3.Choose some task.");
            OutputService.ShowMessage("4.");
            OutputService.ShowMessage("5.Choose some task.");
        }
        public static void Main(string[] args)
        {
            while(true)
            {
                MenuCommand();
                string command = Console.ReadLine();
                string TaskOutput = "Unknown command";
                switch (command)
                {
                    case "1":
                        while (true)
                        {
                            int mounth = Converter.ConvertToInt(InputService.InputString());
                            TaskOutput = IndividualTasksB.IndividualB4(mounth);
                            OutputService.ShowMessage(TaskOutput);
                        }
                        break;
                    case "exit":
                        return;
                }
            }
        }
    }
}
