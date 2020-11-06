using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA2 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskA2(extract.IndividualA2());
        }
        public string GetInfo()
        {
            return "Determined whether the entered letter is a vowel or consonant.";
        }
        private static string IsVowel1(char letter)
        {
            List<char> listVowel = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            string letterType = "";
            if (listVowel.Contains(letter))
            {
                letterType = "Vowel";
            }
            else
            {
                letterType = "Сonsonant";
            }
            return letterType;
        }
        private static string IsVowel2(char letter)
        {
            string letterType = "";
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    letterType = "Vovel";
                    break;
                default:
                    letterType = "Consonant";
                    break;
            }
            return letterType;
        }
        private static string IsVowel3(char letter)
        {
            bool flag = false;
            string letterType = "";
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
                letterType = "Vowel";
            }
            else
            {
                letterType = "Сonsonant";
            }
            return letterType;
        }
        // Individual A2
        public static string IndividualTaskA2(char letter)
        {
            if (letter == null)
            {
                throw new Exception("Error, incorrect data.Transfer letter!");
            }
            return $"{IsVowel1(letter)}\n{IsVowel2(letter)}\n{IsVowel3(letter)}";
        }
    }
}
