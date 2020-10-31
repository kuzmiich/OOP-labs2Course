using System;

namespace Lab4.Modules
{
   public static class IOservice
   {
        public static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string GetUserInputStr()
        {
            return Console.ReadLine();
        }
        public static char GetUserInputLetter()
        {
            return Convert.ToChar(Console.Read());
        }
    }
}
