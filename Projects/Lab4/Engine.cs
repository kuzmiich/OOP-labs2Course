using System;
using System.Collections.Generic;
using System.Collections;

namespace Laba4
{
    class Engine
    {
        public static string Common1(int year)
        {
            int head = 0;
            const int startHead = 3, UpTwoHundred = 3, CoefUpTreeHundred = 2;
            const int zeroYear = 0, TwoHundredYear = 200, TreeHundredYear = 300;
            if (year < TwoHundredYear && year > zeroYear)
            {
                head = year * UpTwoHundred + startHead;
            }
            else if (year >= TwoHundredYear && year < TreeHundredYear)
            {
                head = TwoHundredYear * UpTwoHundred + (year - TwoHundredYear) * CoefUpTreeHundred + startHead;
            }
            else if (year >= TreeHundredYear)
            {
                head = TwoHundredYear * UpTwoHundred + (TreeHundredYear - TwoHundredYear) * CoefUpTreeHundred + (year - TreeHundredYear) + startHead;
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
            Dictionary<int> dict;
        }
        public static string Common2(int[] numbers)
        {
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
        public static bool Common3(int number)
        {
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
        public static string Individual1(int number)
        {
            return ""; 
        }
    }
}
