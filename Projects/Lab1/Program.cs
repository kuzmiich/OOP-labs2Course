using System;

namespace Lab1
{
    class Program
    {
        public static void printConsole<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            printConsole("Hello World!");
            printConsole(14);
            printConsole(15.1);
        }
    }
}