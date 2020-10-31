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
        public static int ConvertToInt(string value)
        {
            int res = 0;
            try
            {
                res = Convert.ToInt32(value);
            }
            catch (FormatException ex)
            {
                IOservice.ShowMessage(ex.Message);
            }
            return res;
        }
        public static char GetUserInputLetter()
        {
            return Convert.ToChar(Console.Read());
        }
    }
}
