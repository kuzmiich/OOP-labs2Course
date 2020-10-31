using System;
using System.ComponentModel.Design;
using Lab4.Modules;

namespace Lab4
{
    class Program
    {
        private static void MenuCommand()
        {
            Console.WriteLine("Tasks:");
        }
        public static void Main(string[] args)
        {
            while(true)
            {
                MenuCommand();
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
                        Console.WriteLine(CommonTasks.Common1(year));
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
                        Console.WriteLine(CommonTasks.Common2(numbers));
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
                        Console.WriteLine("The number is a multiple of numbers: 2, 3, 5, 7, 11, 13, 17 и 19 - " + CommonTasks.Common3(number));
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
                        Console.WriteLine(IndividualTasksA.IndividualA1(a, b, c));
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
                        Console.WriteLine(IndividualTasksA.IndividualA2(letter));
                        break;
                    case "6":
                        Console.WriteLine("The mood of the user:\n");
                        Console.WriteLine(IndividualTasksA.IndividualA3());
                        break;
                    case "7":
                        Console.WriteLine("Roll the dice:\n");
                        Console.WriteLine(IndividualTasksA.IndividualA4());
                        break;
                    case "8":
                        Console.WriteLine("Open the pie with a surprise:\n");
                        Console.WriteLine(IndividualTasksA.IndividualA5());
                        break;
                    case "9":
                        Console.WriteLine("B1:\n");
                        IndividualTasksB.IndividualB1();
                        break;
                    case "10":
                        Console.WriteLine("B2:\n");
                        Console.WriteLine(IndividualTasksB.IndividualB2());
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
}
