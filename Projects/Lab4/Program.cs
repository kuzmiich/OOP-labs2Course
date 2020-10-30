using System;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
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

            // 2
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

            // 3
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

            // 4


        }
    }
}
