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
                string dimaVanLav;
                switch (command)
                {
                    case "1":
                        dimaVanLav = CommonTasks.Common1();
                        break;
                    case "2":
                        dimaVanLav = CommonTasks.Common2();
                        break;
                    case "3":
                        dimaVanLav = CommonTasks.Common3();
                        break;
                    case "4":
                        dimaVanLav = IndividualTasksA.IndividualA1();
                        break;
                    case "5":
                        dimaVanLav = IndividualTasksA.IndividualA2();
                        break;
                    case "6":
                        dimaVanLav = IndividualTasksA.IndividualA3();
                        break;
                    case "7":
                        dimaVanLav = IndividualTasksA.IndividualA4();
                        break;
                    case "8":
                        dimaVanLav = IndividualTasksA.IndividualA5();
                        break;
                    case "9":
                        dimaVanLav = IndividualTasksB.IndividualB1();
                        break;
                    case "10":
                        dimaVanLav = IndividualTasksB.IndividualB2();
                        break;
                    case "11":
                        dimaVanLav = IndividualTasksB.IndividualB3();
                        break;
                    case "12":
                        dimaVanLav = IndividualTasksB.IndividualB4();
                        break;
                    case "13":
                        dimaVanLav = IndividualTasksB.IndividualB5();
                        break;
                    case "14":
                        dimaVanLav = IndividualTasksB.IndividualB6();
                        break;
                    case "15":
                        dimaVanLav = IndividualTasksB.IndividualB7();
                        break;
                    case "16":
                        dimaVanLav = IndividualTasksB.IndividualB8();
                        break;
                    case "17":
                        dimaVanLav = IndividualTasksB.IndividualB9();
                        break;
                    case "18":
                        dimaVanLav = AdditionalTasks.Additional1();
                        break;
                    case "exit":
                        return;
                    default:
                        OutputService.ShowMessage("Unknown command");
                        break;
                }
            }
        }
    }
}
