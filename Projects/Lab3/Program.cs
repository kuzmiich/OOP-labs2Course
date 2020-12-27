using Lab3.help;
using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int centerAmount = 50;
            Console.Title = "Data types in .Net and C#";
            List<IOperationInfo> wrappedPrimitives = new List<IOperationInfo>()
            {        
                new WrappedPrimitive<int>(10, 2),
                new WrappedPrimitive<double>(10.0, 2d),
                new WrappedPrimitive<short>(10, 2),
                new WrappedPrimitive<char>('x', 'f'),
                new WrappedPrimitive<long>(10000, 432),
                new WrappedPrimitive<decimal>(312.23424423m, 424.23432m),
                new WrappedPrimitive<bool>(true, false),
                new WrappedPrimitive<float>(5.3f, 4f),
                new WrappedPrimitive<byte>(125, 5),
            };
            ShowTypeInfoService.GetTypeOperationFuncsWithResultString(wrappedPrimitives);
            Center(centerAmount, "Other operators", "=");
            unsafe
            {
                ExampleStruct exampleStruct = new ExampleStruct();
                ExampleStruct* pointer = &exampleStruct;
                Console.WriteLine("ExampleStruct* pointer = &exampleStruct;");
                pointer->integerValue = 10;
                Console.WriteLine(sizeof(ExampleStruct));
                Console.WriteLine($"pointer->integerValue = {pointer->integerValue}");
            };
            Console.WriteLine($"(2 + 2) * 2 = {(2 + 2) * 2}");
            Console.WriteLine($"2 + 2 * 2 = {2 + 2 * 2}");
            Console.WriteLine();
        }
        

        public static void Center(int amount, string msg, string symbol)
        {
            int divided_amount = amount / 2;
            for (int i = 0; i < amount; i++)
            {

                if (i == divided_amount)
                {
                    Console.Write(msg);
                }
                else
                {
                    Console.Write(symbol);
                }
            }
            Console.Write("\n");
        }
    }
}
