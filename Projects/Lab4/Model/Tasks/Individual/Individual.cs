using System;
using System.Collections.Generic;
using Lab4.Views;
using Lab4.Model.MyConverter;

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
        public static string IndividualA(double a, double b, double c)
        {
            
            return "Is these sides are sides of a triangle - " + IsTriangle(a, b, c);
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
                throw new Exception("Error, program was broken.");
            }
            return smile;
        }
        // Individual A4 - Dice
        public static string IndividualA4(int[] dies)
        {
            return $"On the first die, it fell out - {dies[0]}\nOn the second die, it fell out - {dies[1]}\nResult = {dies[0] + dies[1]}";
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
    class IndividualTasksB
    {
        public static string IndividualB(int dayOfWeek)
        {
            List<string> listDayOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int startRange = 1, endRange = 7;


            if (dayOfWeek >= startRange && dayOfWeek <= endRange)
            {
                return $"Today is - {listDayOfWeek[dayOfWeek - 1]}";
            }
            else
            {
                OutputService.ShowMessage("Error, incorrect data.");
                return "";
            }
        }
        public static string IndividualB2(int mark)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string res = "";
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
                throw new Exception("Error, invalid data.");
            }
            return $"Mark is {res}";
        }
        public static string IndividualB3(int[] arrNumbers)
        {
            int indexAdvantage = arrNumbers[0], indexSuits = arrNumbers[1];
            Dictionary<int, string> cardSuits = new Dictionary<int, string>
            {
                { 1, "peaks" },
                { 2, "club" },
                { 3, "diamond"},
                { 4, "hearts"}
            };
            Dictionary<int, string> cardAdvantage = new Dictionary<int, string> {
                { 6, "Six" },
                { 7, "Seven"},
                { 8, "Eight"},
                { 9, "Nine"},
                { 10, "Ten"},
                { 11, "Eleven"},
                { 12, "twelve"},
                { 13, "thirteen"},
                { 14, "Chetyrnadcati"},
            };
            int countCardAdvantage = cardAdvantage.Count, startKeyAdvantage = 6,
                countCardSuits = cardSuits.Count, startKeySuits = 1;
            
            return cardAdvantage[indexAdvantage + startKeyAdvantage] + " " + cardSuits[indexSuits + startKeySuits];
        }
        public static string IndividualB4(int year)
        {
            /*Dictionary<int, string> dictYears = new Dictionary<int, string>
            {
                { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"}, { 5, "five" }, { 6, "six" }, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
                { 10, "ten"}, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen"}, { 14, "fourteen"}, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen"}, { 18, "eighteen"}, { 19, "nineteen"},
                { 20, "twenty"}, { 21, "twenty one" }, { 22, "twenty two" }, { 23, "twenty three"}, { 24, "twenty four"}, { 25, "twenty five" }, { 26, "twenty six" }, { 27, "twenty seven"}, { 28, "twenty eight"}, { 29, "twenty nine"},
                { 30, "thirty"}, { 31, "thirty one" }, { 32, "thirty two" }, { 33, "thirty three"}, { 34, "thirty four"}, { 35, "thirty five" }, { 36, "thirty six" }, { 37, "thirty seven"}, { 38, "thirty eight"}, { 39, "thirty nine"},
                { 40, "forty"}, { 41, "forty one" }, { 42, "forty two" }, { 43, "forty three"}, { 44, "forty four"}, { 45, "forty five" }, { 46, "forty six" }, { 47, "forty seven"}, { 48, "forty eight"}, { 49, "forty nine"},
                { 50, "fifty"}, { 51, "fifty one" }, { 52, "fifty two" }, { 53, "fifty three"}, { 54, "fifty four"}, { 55, "fifty five" }, { 56, "fifty six" }, { 57, "fifty seven"}, { 58, "fifty eight"}, { 59, "fifty nine"},
                { 60, "sixty"}, { 61, "sixty one" }, { 62, "sixty two" }, { 63, "sixty three"}, { 64, "sixty four"}, { 65, "sixty five" }, { 66, "sixty six" }, { 67, "sixty seven"}, { 68, "sixty eight"}, { 69, "sixty nine"},
                { 70, "seventy"}, { 71, "seventy one" }, { 72, "seventy two" }, { 73, "seventy three"}, { 74, "seventy four"}, { 75, "seventy five" }, { 76, "seventy six" }, { 77, "seventy seven"}, { 78, "seventy eight"}, { 79, "seventy nine"},
                { 80, "eighty"}, { 81, "eighty one" }, { 82, "eighty two" }, { 83, "eighty three"}, { 84, "eighty four"}, { 85, "eighty five" }, { 86, "eighty six" }, { 87, "eighty seven"}, { 88, "eighty eight"}, { 89, "eighty nine"},
                { 90, "ninety"}, { 91, "ninety one" }, { 92, "ninety two" }, { 93, "ninety three"}, { 94, "ninety four"}, { 95, "ninety five" }, { 96, "ninety six" }, { 97, "ninety seven"}, { 98, "ninety eight"}, { 99, "ninety nine"},
                { 100, "one hundred"}, { 101, "one hundred one" }, { 102, "one hundred two" }, { 103, "one hundred three"}, { 104, "one hundred four"}, { 105, "one hundred five" }, { 106, "one hundred six" }, { 107, "one hundred seven"}, { 108, "one hundred eight"}, { 109, "one hundred nine"},
                { 110, "one hundred ten"}, { 111, "one hundred eleven" }, { 112, "one hundred twelve" }, { 113, "one hundred thirteen"}, { 114, "one hundred fourteen"}, { 115, "one hundred fifteen" }, { 116, "one hundreed sixty" }, { 117, "one hundred seventy"}, { 118, "one hundred eighty"}, { 119, "one hundred nineteen"},
                { 120, "one hundred twenty"},
            };*/
            int lower = 1, upper = 4, coefFactor = 10;
            int exceptionalYear = 1;
            string resYear = "";
            /*if (year == exceptionalYear)
            {
                resYear = dictYears[year] + " year";
            }
            else if (year % coefFactor <= lower && year % coefFactor >= upper)
            {
                resYear = dictYears[year] + " years old";
            }
            else
            {
                resYear = dictYears[year] + " years";
            }*/
            return resYear;
        }
        // count of day in mount for not a leap year
        public static string IndividualB5()
        {
            Dictionary<int, string> mounthDict = new Dictionary<int, string>
            {
                { 1, "January" }, { 2, "February" }, { 3, "March" }, { 4, "April"}, { 5, "May"}, { 6, "June" },
                { 7, "July" }, { 8, "August"}, { 9, "September"}, { 10, "October"}, { 11, "November"}, { 12, "December"}
            };
            string numberDays = "";
            uint numberMounth = Converter.ConvertToUInt(InputService.InputString());
            uint numberYear = Converter.ConvertToUInt(InputService.InputString());

            return numberDays;
        }
        public static string IndividualB6()
        {
            Dictionary<int, string> mounthDict = new Dictionary<int, string>
            {
                { 1, "January" }, { 2, "February" }, { 3, "March" }, { 4, "April"}, { 5, "May"}, { 6, "June" },
                { 7, "July" }, { 8, "August"}, { 9, "September"}, { 10, "October"}, { 11, "November"}, { 12, "December"}
            };
            string resTimeYear = "";
            int numberMounth = Converter.ConvertToInt(InputService.InputString());
            if (numberMounth > 1 && numberMounth < 3 || numberMounth == 12)
            {
                resTimeYear = "Winter";
            }
            else if (numberMounth >= 3 & numberMounth < 6)
            {
                resTimeYear = "Spring";
            }
            else if (numberMounth >= 6 && numberMounth < 9)
            {
                resTimeYear = "Summer";
            }
            else if (numberMounth >= 9 && numberMounth < 12)
            {
                resTimeYear = "Autumn";
            }
            else
            {
                OutputService.ShowMessage("Error, invalid data.");
                return "";
            }
            return resTimeYear;
        }

        public static string IndividualB7()
        {
            List<string> listOperations = new List<string> { "+", "-", "*", "/", "%" };
            var operation = InputService.GetUserInputLetter();
            var number1 = Converter.ConvertToInt(InputService.InputString());
            var number2 = Converter.ConvertToInt(InputService.InputString());
            double resNumber = 0;
            switch(operation)
            {
                case '+':
                    resNumber = number1 + number2;
                    break;
                case '-':
                    resNumber = number1 - number2;
                    break;
                case '*':
                    resNumber = number1 * number2;
                    break;
                case '/':
                    try
                    {
                        resNumber = number1 / number2;
                    }
                    catch (DivideByZeroException ex)
                    {
                        throw ex;
                    }
                    break;
                case '%':
                    try
                    {
                        resNumber = number1 % number2;
                    }
                    catch (DivideByZeroException ex)
                    {
                        throw ex;
                    }
                    break;
                default:
                    OutputService.ShowMessage("Error, not the correct operation.");
                    break;
            }
            return resNumber.ToString();
        }
        public static string IndividualB8(int day, int mounth)
        {

            int twentyTree = 23, twentyTwo = 22, twentyOne = 21, twenty = 20, nineteen = 19;
            string zodiacSign = "";
            switch (mounth)
            {
                case 1:
                    if (day < twentyOne) { zodiacSign = "Capricorn"; } else { zodiacSign = "Aquarius"; }
                    break;
                case 2:
                    if (day < nineteen) { zodiacSign = "Aquarius"; } else { zodiacSign = "Fish"; }
                    break;
                case 3:
                    if (day < twentyOne) { zodiacSign = "Fish"; } else { zodiacSign = "Aries"; }
                    break;
                case 4:
                    if (day < twenty) { zodiacSign = "Aries"; } else { zodiacSign = "Taurus"; }
                    break;
                case 5:
                    if (day < twentyOne) { zodiacSign = "Taurus"; } else { zodiacSign = "Twins"; }
                    break;
                case 6:
                    if (day < twentyTwo) { zodiacSign = "Twins"; } else { zodiacSign = "Cancer"; }
                    break;
                case 7:
                    if (day < twentyTree) { zodiacSign = "Cancer"; } else { zodiacSign = "Lion"; }
                    break;
                case 8:
                    if (day < twentyTree) { zodiacSign = "Lion"; } else { zodiacSign = "Maid"; }
                    break;
                case 9:
                    if (day < twentyTree) { zodiacSign = "Maid"; } else { zodiacSign = "Scales"; }
                    break;
                case 10:
                    if (day < twentyTree) { zodiacSign = "Scales"; } else { zodiacSign = "Scorpio"; }
                    break;
                case 11:
                    if (day < twentyTree) { zodiacSign = "Scorpio"; } else { zodiacSign = "Sagittarius"; }
                    break;
                case 12:
                    if (day < twentyTwo) { zodiacSign = "Sagittarius"; } else { zodiacSign = "Capricorn"; }
                    break;
                default: 
                    OutputService.ShowMessage("Неизвестная операция");
                    break;
            }
            return zodiacSign;
        }
        public static string IndividualB9(int number)
        {
            Dictionary<int, string> dictOneHundredNumbers = new Dictionary<int, string>
            {
                { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"}, { 5, "five" }, { 6, "six" }, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
                { 10, "ten"}, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen"}, { 14, "fourteen"}, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen"}, { 18, "eighteen"}, { 19, "nineteen"},
                { 20, "twenty"}, { 21, "twenty one" }, { 22, "twenty two" }, { 23, "twenty three"}, { 24, "twenty four"}, { 25, "twenty five" }, { 26, "twenty six" }, { 27, "twenty seven"}, { 28, "twenty eight"}, { 29, "twenty nine"},
                { 30, "thirty"}, { 31, "thirty one" }, { 32, "thirty two" }, { 33, "thirty three"}, { 34, "thirty four"}, { 35, "thirty five" }, { 36, "thirty six" }, { 37, "thirty seven"}, { 38, "thirty eight"}, { 39, "thirty nine"},
                { 40, "forty"}, { 41, "forty one" }, { 42, "forty two" }, { 43, "forty three"}, { 44, "forty four"}, { 45, "forty five" }, { 46, "forty six" }, { 47, "forty seven"}, { 48, "forty eight"}, { 49, "forty nine"},
                { 50, "fifty"}, { 51, "fifty one" }, { 52, "fifty two" }, { 53, "fifty three"}, { 54, "fifty four"}, { 55, "fifty five" }, { 56, "fifty six" }, { 57, "fifty seven"}, { 58, "fifty eight"}, { 59, "fifty nine"},
                { 60, "sixty"}, { 61, "sixty one" }, { 62, "sixty two" }, { 63, "sixty three"}, { 64, "sixty four"}, { 65, "sixty five" }, { 66, "sixty six" }, { 67, "sixty seven"}, { 68, "sixty eight"}, { 69, "sixty nine"},
                { 70, "seventy"}, { 71, "seventy one" }, { 72, "seventy two" }, { 73, "seventy three"}, { 74, "seventy four"}, { 75, "seventy five" }, { 76, "seventy six" }, { 77, "seventy seven"}, { 78, "seventy eight"}, { 79, "seventy nine"},
                { 80, "eighty"}, { 81, "eighty one" }, { 82, "eighty two" }, { 83, "eighty three"}, { 84, "eighty four"}, { 85, "eighty five" }, { 86, "eighty six" }, { 87, "eighty seven"}, { 88, "eighty eight"}, { 89, "eighty nine"},
                { 90, "ninety"}, { 91, "ninety one" }, { 92, "ninety two" }, { 93, "ninety three"}, { 94, "ninety four"}, { 95, "ninety five" }, { 96, "ninety six" }, { 97, "ninety seven"}, { 98, "ninety eight"}, { 99, "ninety nine"},
                { 100, "one hundred"}, { 101, "one hundred one" }, { 102, "one hundred two" }, { 103, "one hundred three"}, { 104, "one hundred four"}, { 105, "one hundred five" }, { 106, "one hundred six" }, { 107, "one hundred seven"}, { 108, "one hundred eight"}, { 109, "one hundred nine"},
                { 110, "one hundred ten"}, { 111, "one hundred eleven" }, { 112, "one hundred twelve" }, { 113, "one hundred thirteen"}, { 114, "one hundred fourteen"}, { 115, "one hundred fifteen" }, { 116, "one hundreed sixty" }, { 117, "one hundred seventy"}, { 118, "one hundred eighty"}, { 119, "one hundred nineteen"},
                { 120, "one hundred twenty"},
            };
            OutputService.ShowMessage("*** The name of the number as a string ***");

            return "";
        }
    }
}