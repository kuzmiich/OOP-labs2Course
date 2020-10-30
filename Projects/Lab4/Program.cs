using System;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    Console.WriteLine("Input count of heads: ");
                    int year = 0;
                    try
                    {
                        year = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine(Engine.Common1(year));
                    break;
                case "2":
                    Console.WriteLine("Fill in the array of numbers:");
                    int[] numbers = null;
                    try
                    {
                        numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine(Engine.Common2(numbers));
                    break;
                case "3":
                    Console.WriteLine("Input number: ");
                    int number = 0;
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine("The number is a multiple of numbers: 2, 3, 5, 7, 11, 13, 17 и 19 - " + Engine.Common3(number));
                    break;
                case "4":
                    Console.WriteLine("Input 3 sides: ");
                    double a = 0;
                    double b = 0;
                    double c = 0;
                    try
                    {
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        c = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine(Engine.IndividualA1(a, b, c));
                    break;
                case "5":
                    Console.WriteLine("Input letter: ");
                    char letter = ' ';
                    try
                    {
                        letter = Convert.ToChar(Console.Read());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine(Engine.IndividualA2(letter));
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
    }
}
