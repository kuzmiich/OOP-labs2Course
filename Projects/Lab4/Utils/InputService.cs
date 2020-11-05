using System;

namespace Lab4.Utils
{
    public class InputService : IInputService
    {
        private static readonly object _syncRoot = new object();
        private static InputService _instance;
        public static InputService GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new InputService();
                    }
                }
            }
            return _instance;
        }
        private InputService()
        {

        }
        public string InputString()
        {
            return Console.ReadLine();
        }
        public char GetUserInputLetter()
        {
            return Convert.ToChar(Console.Read());
        }
    }
}
