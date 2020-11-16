using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB4 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB4(extract.IndividualB4());
        }
        public string GetInfo()
        {
            return "Displays a string describing the specified age, ensuring that the number matches the word \'year\' correctly:";
        }
        private static string AddEnding(int year, string stringNumber)
        {
            int lower = 1,
                upper = 4,
                coefFactor = 10,
                exceptionalYear = 1;
            string resYear = "";
            if (year == exceptionalYear)
            {
                resYear = stringNumber + " year";
            }
            else if (year % coefFactor >= lower && year % coefFactor <= upper)
            {
                resYear = stringNumber + " years old";
            }
            else if (!(year % coefFactor >= lower && year % coefFactor <= upper))
            {
                resYear = stringNumber + " years";
            }
            else
            {
                throw new Exception();
            }
            return resYear;
        }
        //TODO Replace const
        public static string IndividualTaskB4(int year)
        {
            Dictionary<int, string> dictYears = new Dictionary<int, string>
            {
                { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"}, { 5, "five" }, { 6, "six" }, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
                { 10, "ten"}, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen"}, { 14, "fourteen"}, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen"}, { 18, "eighteen"}, { 19, "nineteen"},
                { 20, "twenty"}, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" }, { 60, "sixty"}, { 70, "seventy" }, { 80, "eighty" }, { 90, "nineteen" }, { 100, "hundred" }
            };
            string stringNumber = "";
            // hundred
            if (year / 100 > 0 && year / 100 < 10)
            {
                int hundreds = year / 100;
                int tens = year % 100;
                stringNumber += $"{dictYears[hundreds]} {dictYears[100]} {dictYears[tens]}";
            }
            else if (year / 10 > 0 && year > 20)
            {
                int tens = year / 10;
                int digit = year % 10;
                stringNumber += $"{dictYears[tens * 10]} {dictYears[digit]}";
            }
            else if (year >= 0)// from 0 to 20
            {
                stringNumber = dictYears[year];
            }
            else
            {
                throw new Exception("Error, program was broken.Transfer number from 0 to 120");
            }
            return AddEnding(year, stringNumber);
        }
    }
}
