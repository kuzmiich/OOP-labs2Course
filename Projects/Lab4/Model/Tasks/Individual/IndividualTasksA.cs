using System;
using System.Collections.Generic;
using Lab4.Views;

namespace Lab4.Model.Tasks.Individual
{
    static class IndividualTasksA
    {
        // Individual A1
        private static bool IsTriangle(double a, double b, double c)
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
        public static string IndividualA(double aSide, double bSide, double cSide)
        {
            const double ZERO = 0;
            if (aSide < ZERO || bSide < ZERO || cSide < ZERO)
            {
                throw new Exception("Error, incorrect data.Input number more than 0");
            }
            return "Is these sides are sides of a triangle - " + IsTriangle(aSide, bSide, cSide);
        }
        // Individual A2
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
        public static string IndividualA2(char letter)
        {
            return $"{IsVowel1(letter)}\n{IsVowel2(letter)}\n{IsVowel3(letter)}";
        }
        // Individual A3 - Mood sensor
        private static string BadMood()
        {
            return "͡Ò﹏Ó";
        }
        private static string GoodMood()
        {
            return "¯＼_(ツ)_/¯";
        }
        private static string PerfectMood()
        {
            return "(o˘◡˘o)";
        }
        public static string IndividualA3(int mood)
        {
            string smile = "";
            const int ZERO = 0,
                THIRTYTREE = 33,
                SIXTYSIX = 66;
            if (mood >= ZERO && mood < THIRTYTREE)
            {
                smile = BadMood();
            }
            else if (mood >= THIRTYTREE && mood < SIXTYSIX)
            {
                smile = GoodMood();
            }
            else if (mood >= SIXTYSIX)
            {
                smile = PerfectMood();
            }
            else
            {
                throw new Exception("Error, program was broken.Transfer number from 0 to 100");
            }
            return smile;
        }
        // Individual A4 - Dice
        public static string IndividualA4(int firstNumber, int secondNumber)
        {
            return $"On the first die, it fell out - {firstNumber}\nOn the second die, it fell out - {secondNumber}\nResult = {firstNumber + secondNumber}";
        }
        // Individual A5 - Simulator of pies with a surprise
        public static string IndividualA5(int index)
        {
            OutputService.ShowMessage("Open the pie with a surprise:\n");
            List<string> listSurprise = new List<string>() 
            {    "Помни, что каждый день — первый в оставшейся части жизни.",
                 "В жизни есть главное и не главное, а мы часто тратим силы на пустяки.",
                 "Не так хорошо, как хотелось, но и не так плохо, как могло было быть!",
                 "Делай что должен, и будь что будет.Люди любят побеждать.Если вы не определились с окончательной целью, шансов на победу у вас нет.",
                 "Обратная сторона кризиса — новые возможности.",
                 "Не каждый может быть твоим другом, но каждый может быть твоим учителем.",
                 "Если истинно желаешь быть счастливым — научись властвовать своими мыслями.",
                 "Каждому причитается столько счастья, сколько сам в силах подарить.",
                 "Если хотите иметь успех, вы должны выглядеть так, как будто вы его имеете."
             };
            return listSurprise[index];
        }
    }
}