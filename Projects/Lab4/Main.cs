using Lab4.Views;
using Lab4.Utils;
using Lab4.Controller;

namespace Lab4
{
    class Program
    {
        private static IInputService inputService;
        private static IOutputService outputService;
        private static MainController mainController;

        private static void MenuCommand()
        {
            outputService.ShowMessage("1.Show all tasks");
            outputService.ShowMessage("2.Choose task type.");
            outputService.ShowMessage("3.Choose some task.");
            outputService.ShowMessage("4.");
            outputService.ShowMessage("5.Choose some task.");
        }

        public static void Main(string[] args)
        {

        }
    }
}
