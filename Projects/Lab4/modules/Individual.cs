using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Lab4.Modules
{
    class IndividualTasksA
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
        public static string IndividualA1()
        {
            Console.WriteLine("Input 3 sides: ");
            double a = 0;
            double b = 0;
            double c = 0;
            a = IOservice.ConvertToInt(IOservice.GetUserInputStr());
            b = IOservice.ConvertToInt(IOservice.GetUserInputStr());
            c = IOservice.ConvertToInt(IOservice.GetUserInputStr());
            return "Is these sides are sides of a triangle - " + IsTriangle(a, b, c);
        }
        // Individual A2
        private static string IsVowel1(char letter)
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
        private static string IsVowel2(char letter)
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
        private static string IsVowel3(char letter)
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
        public static string IndividualA2()
        {
            Console.WriteLine("Input letter: ");
            char letter = ' ';
            try
            {
                letter = Convert.ToChar(IOservice.GetUserInputLetter());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
        public static string IndividualA3()
        {
            IOservice.ShowMessage("The mood of the user:\n");
            Random rand = new Random();
            int mood = rand.Next(100);
            string smile = "";
            if (mood > 0 && mood < 33)
            {
                smile = BadMood();
            }
            else if (mood >= 33 && mood < 66)
            {
                smile = GoodMood();
            }
            else if (mood >= 66)
            {
                smile = PerfectMood();
            }
            else
            {
                smile = "Error, program was broken.";
            }
            return smile;
        }
        // Individual A4 - Dice
        public static string IndividualA4()
        {
            IOservice.ShowMessage("Roll the dice:\n");
            Random rand = new Random();
            int countPoint = 6;
            int firstDie = rand.Next(countPoint);
            int secondDie = rand.Next(countPoint);
            return $"On the first die, it fell out - {firstDie}\nOn the second die, it fell out - {secondDie}\nResult = {firstDie + secondDie}";
        }
        // Individual A5 - Simulator of pies with a surprise
        public static string IndividualA5()
        {
            IOservice.ShowMessage("Open the pie with a surprise:\n");
           
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

            dayOfWeek = IOservice.ConvertToInt(IOservice.GetUserInputStr());


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
            IOservice.ShowMessage("Input number from 0 to 10:");
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int mark = 0;
            string res = "";
            mark = IOservice.ConvertToInt(IOservice.GetUserInputStr());
            if (mark >= numbers[0] && mark <= numbers[1])
            {
                res = "Very bad";
            }
            else if (mark >= numbers[2] && mark <= numbers[3])
            {
                res = "Unsatisfactory";
            }
            else if (mark >= numbers[4] && mark <= numbers[5])
            {
                res = "Satisfactory";
            }
            else if (mark >= numbers[6] && mark <= numbers[7])
            {
                res = "Good";
            }
            else if (mark >= numbers[8] && mark <= numbers[10])
            {
                res = "Perfect";
            }
            else
            {
                IOservice.ShowMessage("Error, invalid data.");
                return "";
            }
            return $"Mark is {res}";
        }
        public static string IndividualB3()
        {
            Dictionary<int, string> cardSuits = new Dictionary<int, string>(4);
            cardSuits.Add(1, "Червы");
            return "";
        }
    }
}