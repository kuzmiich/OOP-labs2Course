using System;
using Lab4.Modules;

namespace Lab4
{
    class Program
    {
        private static void MenuCommand()
        {
            IOservice.ShowMessage("");
        }
        public static void Main(string[] args)
        {
            while(true)
            {
                MenuCommand();
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        IOservice.ShowMessage(CommonTasks.Common1());
                        break;
                    case "2":
                        IOservice.ShowMessage(CommonTasks.Common2());
                        break;
                    case "3":
                        IOservice.ShowMessage("The number is a multiple of numbers: 2, 3, 5, 7, 11, 13, 17 и 19 - " + CommonTasks.Common3());
                        break;
                    case "4":
                        IOservice.ShowMessage(IndividualTasksA.IndividualA1());
                        break;
                    case "5":
                        IOservice.ShowMessage(IndividualTasksA.IndividualA2());
                        break;
                    case "6":
                        IOservice.ShowMessage(IndividualTasksA.IndividualA3());
                        break;
                    case "7":
                        IOservice.ShowMessage(IndividualTasksA.IndividualA4());
                        break;
                    case "8":
                        IOservice.ShowMessage(IndividualTasksA.IndividualA5());
                        break;
                    case "9":
                        IndividualTasksB.IndividualB1();
                        break;
                    case "10":
                        IOservice.ShowMessage(IndividualTasksB.IndividualB2());
                        break;
                    case "11":
                        IOservice.ShowMessage(IndividualTasksB.IndividualB2());
                        break;
                    case "12":
                        IOservice.ShowMessage(IndividualTasksB.IndividualB3());
                        break;
                    case "exit":
                        return;
                    default:
                        IOservice.ShowMessage("Unknown command");
                        break;
                }
            }
        }
    }
}
