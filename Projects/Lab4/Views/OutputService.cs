using System;

namespace Lab4.Views
{
   abstract public class OutputService : IOutputService
   {
        public static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
