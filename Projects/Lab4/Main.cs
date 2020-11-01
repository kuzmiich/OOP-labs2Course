using System;
using Lab4.Views;
using Lab4.Model.Tasks.Common;
using Lab4.Model.Tasks.Individual;
using Lab4.Model.Tasks.Additional;

namespace Lab4
{
    class Program
    {
        private static void MenuCommand()
        {
            OutputService.ShowMessage("1.Show all tasks\n");
            OutputService.ShowMessage("2.\n");
            OutputService.ShowMessage("3.\n");
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
                        TaskOutput = CommonTasks.Common1();
                        break;
                    case "2":
                        TaskOutput = CommonTasks.Common2();
                        break;
                    case "3":
                        TaskOutput = CommonTasks.Common3();
                        break;
                    case "4":
                        TaskOutput = IndividualTasksA.IndividualA1();
                        break;
                    case "5":
                        TaskOutput = IndividualTasksA.IndividualA2();
                        break;
                    case "6":
                        TaskOutput = IndividualTasksA.IndividualA3();
                        break;
                    case "7":
                        TaskOutput = IndividualTasksA.IndividualA4();
                        break;
                    case "8":
                        TaskOutput = IndividualTasksA.IndividualA5();
                        break;
                    case "9":
                        TaskOutput = IndividualTasksB.IndividualB1();
                        break;
                    case "10":
                        TaskOutput = IndividualTasksB.IndividualB2();
                        break;
                    case "11":
                        TaskOutput = IndividualTasksB.IndividualB3();
                        break;
                    case "12":
                        TaskOutput = IndividualTasksB.IndividualB4();
                        break;
                    case "13":
                        TaskOutput = IndividualTasksB.IndividualB5();
                        break;
                    case "14":
                        TaskOutput = IndividualTasksB.IndividualB6();
                        break;
                    case "15":
                        TaskOutput = IndividualTasksB.IndividualB7();
                        break;
                    case "16":
                        TaskOutput = IndividualTasksB.IndividualB8();
                        break;
                    case "17":
                        TaskOutput = IndividualTasksB.IndividualB9();
                        break;
                    case "18":
                        TaskOutput = AdditionalTasks.Additional1();
                        break;
                    case "exit":
                        return;
                }
                OutputService.ShowMessage(TaskOutput);
            }
        }
    }
}
