using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.OutputService.ConsoleOutput
{
    public class ConsoleOutput : IConsoleOutput
    {
        private static readonly object _syncRoot = new object();
        private static ConsoleOutput _instance;

        public static ConsoleOutput GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new ConsoleOutput();
                    }
                }
            }
            return _instance;
        }

        private ConsoleOutput()
        {

        }

        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string ConvertIEnumerableToString<T>(IEnumerable<T> enumerable)
        {
            var builder = new StringBuilder();
            foreach (var element in enumerable)
            {
                builder.AppendFormat("{0} ", element);
            }
            return builder.ToString();
        }
    }
}
