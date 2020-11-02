using System;

namespace Lab4.Views
{
    class InputService : IInputService
    {
        public static string InputString()
        {
            return Console.ReadLine();
        }
        public static char GetUserInputLetter()
        {
            return Convert.ToChar(Console.Read());
        }
    }
}
