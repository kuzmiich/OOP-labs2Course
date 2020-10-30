﻿using System;
using System.Collections.Generic;

namespace Laba4
{
    class Engine
    {
        public static string Common1(int year)
        {
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
        //
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
        // Individual A1
        private static bool isTriangle(double a, double b, double c)
        {
            if (c > a && a > b && c < a + b && c > a - b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string IndividualA1(double a, double b, double c)
        {
            return "Is these sides are sides of a triangle - " + isTriangle(a, b, c);
        }
        // Individual A2
        private static bool isVowel1(char letter)
        {
            List<char> listVowel = new List<char>{ 'a', 'e', 'i', 'o', 'u' };
            return listVowel.Contains(letter);
        }
        private static bool isVowel2(char letter)
        {
            return true;
        }
        private static bool isVowel3(char letter)
        {
            return true;
        }
        public static string IndividualA2(char letter)
        {
            return $"{isVowel1(letter)}\n{isVowel2(letter)}\n{isVowel2(letter)}";
        }
    }
}
