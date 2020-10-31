using System;
using System.Collections.Generic;

namespace Lab4.Modules
{
    class CommonTasks
    {
        // Define count of dragon heads and eyes
        public static string Common1()
        {
            IOservice.ShowMessage("Input count of heads: ");
            int year = 0;
            year = IOservice.ConvertToInt(IOservice.GetUserInputStr());
            
            int head = 0;
            const int startHead = 3, CoefUpTwoHundred = 3, CoefUpTreeHundred = 2;
            const int zeroYear = 0, TwoHundredYear = 200, TreeHundredYear = 300;
            if (year < TwoHundredYear && year > zeroYear)
            {
                head = year * CoefUpTwoHundred + startHead;
            }
            else if (year >= TwoHundredYear && year < TreeHundredYear)
            {
                head = TwoHundredYear * CoefUpTwoHundred + (year - TwoHundredYear) * CoefUpTreeHundred + startHead;
            }
            else if (year >= TreeHundredYear)
            {
                head = TwoHundredYear * CoefUpTwoHundred + (TreeHundredYear - TwoHundredYear) * CoefUpTreeHundred + (year - TreeHundredYear) + startHead;
            }
            else
            {
                return "Error, incorrect data!";
            }
            int eyes = head * 2;
            return $"Count heads = {head}, count eyes = {eyes}";
        }
        // The Greatest
        private static bool isAllValuesEquel(int[] numbers)
        {
            bool flag = false;
            for (int i = 1; i < numbers.Length; i++)
            {
                
                if (numbers[0] == numbers[i])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                    // return false;
                }
            }
            return flag;
        }
        public static string Common2()
        {
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
            if (isAllValuesEquel(numbers))
            {
                return "All values are equal.";
            }
            int max = numbers[0], min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return $"Max = {max}, Min = {min}";
        }
        //
        public static bool Common3()
        {
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
            List<int> listdividers = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (var el in listdividers)
            {
                if (number % el == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
