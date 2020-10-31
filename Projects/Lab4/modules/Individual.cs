using System;
using System.Collections.Generic;

namespace Lab4.Modules
{
    class IndividualTasksA
    {
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
        private static string isVowel1(char letter)
        {
            List<char> listVowel = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            if (listVowel.Contains(letter))
            {
                return "Vowel";
            }
            else
            {
                return "Сonsonant";
            }
        }
        private static string isVowel2(char letter)
        {
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return "Vovel";
                default:
                    return "Consonant";
            }
        }
        private static string isVowel3(char letter)
        {
            bool flag = false;
            if (letter == 'a')
            {
                flag = true;
            }
            else if (letter == 'e')
            {
                flag = true;
            }
            else if (letter == 'i')
            {
                flag = true;
            }
            else if (letter == 'o')
            {
                flag = true;
            }
            else if (letter == 'u')
            {
                flag = true;
            }

            if (flag)
            {
                return "Vowel";
            }
            else
            {
                return "Сonsonant";
            }
        }
        public static string IndividualA2(char letter)
        {
            return $"{isVowel1(letter)}\n{isVowel2(letter)}\n{isVowel3(letter)}";
        }
        // Individual A3 - Mood sensor
        private static string badMood()
        {
            return "͡Ò﹏Ó";
        }
        private static string goodMood()
        {
            return "¯＼_(ツ)_/¯";
        }
        private static string perfectMood()
        {
            return "(o˘◡˘o)";
        }
        public static string IndividualA3()
        {
            Random rand = new Random();
            int mood = rand.Next(100);
            if (mood > 0 && mood < 33)
            {
                return badMood();
            }
            else if (mood >= 33 && mood < 66)
            {
                return goodMood();
            }
            else if (mood >= 66)
            {
                return perfectMood();
            }
            else
            {
                return "Error, program was broken.";
            }
        }
        // Individual A4 - Dice
        public static string IndividualA4()
        {
            Random rand = new Random();
            int countPoint = 6;
            int firstDie = rand.Next(countPoint);
            int secondDie = rand.Next(countPoint);
            return $"On the first die, it fell out - {firstDie}\nOn the second die, it fell out - {secondDie}\nResult = {firstDie + secondDie}";
        }
        // Individual A5 - Simulator of pies with a surprise
        public static string IndividualA5()
        {
            List<string> listSurprise = new List<string>() { "", "", "", "", "", "", "" };
            Random rand = new Random();
            int index = rand.Next(listSurprise.Count - 1);
            return listSurprise[index];
        }
    }
    class IndividualTasksB
    {
        public static void IndividualB1()
        {
            IOservice.ShowMessage("Input number from 1 to 7:");
            List<string> listDayOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int dayOfWeek = 0, startRange = 1, endRange = 7;
            try
            {
                dayOfWeek = Convert.ToInt32(IOservice.GetUserInputStr());
            }
            catch (FormatException ex)
            {
                IOservice.ShowMessage(ex.Message);
            }
            if (dayOfWeek >= startRange && dayOfWeek <= endRange)
            {
                IOservice.ShowMessage($"Today is - {listDayOfWeek[dayOfWeek - 1]}");
            }
            else
            {
                IOservice.ShowMessage("Error, incorrect data.");
            }
        }
        public static string IndividualB2()
        {
            return "";
        }
    }
}