using System;
using System.Collections.Generic;
using Lab4.Views;

namespace Lab4.Model.Tasks.Individual
{
    class IndividualTasksB
    {
        public static string IndividualB(int dayOfWeek)
        {
            List<string> listDayOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            const int STARTRANGE = 1, ENDRANGE = 7;


            if (dayOfWeek >= STARTRANGE && dayOfWeek <= ENDRANGE)
            {
                return $"Today is - {listDayOfWeek[dayOfWeek - 1]}";
            }
            else
            {
                throw new Exception("Error, incorrect data.Transfer number from 1 to 7");
            }
        }
        public static string IndividualB2(int mark)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            const int ZERO = 0,
                TWO = 2,
                FOUR = 4,
                SIX = 6,
                EIGHT = 8,
                TEN = 10;

            string res = "";
            if (mark >= numbers[ZERO] && mark < numbers[TWO])
            {
                res = "Very bad";
            }
            else if (mark > numbers[TWO] && mark <= numbers[FOUR])
            {
                res = "Unsatisfactory";
            }
            else if (mark > numbers[FOUR] && mark <= numbers[SIX])
            {
                res = "Satisfactory";
            }
            else if (mark > numbers[SIX] && mark <= numbers[EIGHT])
            {
                res = "Good";
            }
            else if (mark > numbers[EIGHT] && mark <= numbers[TEN])
            {
                res = "Perfect";
            }
            else
            {
                throw new Exception("Error, invalid data.");
            }
            return $"Mark is {res}";
        }
        public static string IndividualB3(int indexAdvantage, int indexSuits)
        {
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
        //
        private static string addEnding(int year, string stringNumber)
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
        public static string IndividualB4(int year)
        {
            Dictionary<int, string> dictYears = new Dictionary<int, string>
            {
                { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"}, { 5, "five" }, { 6, "six" }, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
                { 10, "ten"}, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen"}, { 14, "fourteen"}, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen"}, { 18, "eighteen"}, { 19, "nineteen"},
                { 20, "twenty"}, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" }, { 60, "sixty"}, { 70, "seventy" }, { 80, "eighty" }, { 90, "nineteen" }, { 100, "hundred" }
            };
            const int HUNDRED = 100,
                TWENTY = 20,
                TEN = 10,
                ZERO = 0;
            string stringNumber = "";
            // hundred
            if (year / HUNDRED > ZERO && year / HUNDRED < TEN)
            {
                int hundreds = year / HUNDRED;
                int tens = year % HUNDRED;
                stringNumber += dictYears[hundreds] + " " + dictYears[HUNDRED] + " " + dictYears[tens];
            }
            else if (year / TEN > ZERO && year > TWENTY)
            {
                int tens = year / TEN;
                int digit = year % TEN;
                stringNumber += dictYears[tens * TEN] + " " + dictYears[digit];
            }
            else if (year >= ZERO)// from 0 to 20
            {
                stringNumber = dictYears[year];
            }
            else
            {
                throw new Exception("Error, program was broken.Transfer number from 0 to 120");
            }
            return addEnding(year, stringNumber);
        }
        // count of day in mount for not a leap year
        public static string IndividualB5(int[] arrData)
        {
            Dictionary<int, string> mounthDict = new Dictionary<int, string>
            {
                { 1, "January" }, { 2, "February" }, { 3, "March" }, { 4, "April"}, { 5, "May"}, { 6, "June" },
                { 7, "July" }, { 8, "August"}, { 9, "September"}, { 10, "October"}, { 11, "November"}, { 12, "December"}
            };
            string numberDays = "";

            return numberDays;
        }
        public static string IndividualB6(int numberMounth)
        {
            Dictionary<int, string> mounthDict = new Dictionary<int, string>
            {
                { 1, "January" }, { 2, "February" }, { 3, "March" }, { 4, "April"}, { 5, "May"}, { 6, "June" },
                { 7, "July" }, { 8, "August"}, { 9, "September"}, { 10, "October"}, { 11, "November"}, { 12, "December"}
            };
            const int ONE = 1,
                THREE = 3,
                SIX = 6,
                NINE = 9,
                TWELVE = 12;
            string resTimeYear = "";
            if (numberMounth >= ONE && numberMounth < THREE || numberMounth == TWELVE)
            {
                resTimeYear = "Winter";
            }
            else if (numberMounth >= THREE && numberMounth < SIX)
            {
                resTimeYear = "Spring";
            }
            else if (numberMounth >= SIX && numberMounth < NINE)
            {
                resTimeYear = "Summer";
            }
            else if (numberMounth >= NINE && numberMounth < TWELVE)
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

        public static string IndividualB7(char operation, int number1, int number2)
        {
            const char PLUS = '+',
                MINUS = '-',
                POW = '*',
                DIVISION = '/',
                divisionRemainder = '%';
            double resNumber = 0;
            switch (operation)
            {
                case PLUS:
                    resNumber = number1 + number2;
                    break;
                case MINUS:
                    resNumber = number1 - number2;
                    break;
                case POW:
                    resNumber = number1 * number2;
                    break;
                case DIVISION:
                    try
                    {
                        resNumber = number1 / number2;
                    }
                    catch (DivideByZeroException ex)
                    {
                        throw ex;
                    }
                    break;
                case divisionRemainder:
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
                    OutputService.ShowMessage("Error, not correct operation.");
                    break;
            }
            return resNumber.ToString();
        }
        public static string IndividualB8(int day, int mounth)
        {

            const int TWENTYTHREE = 23,
                TEWNTYTWO = 22,
                TWENTYONE = 21,
                TWENTY = 20,
                NINETEEN = 19;
            string zodiacSign = "";
            switch (mounth)
            {
                case 1:
                    if (day < TWENTYONE) { zodiacSign = "Capricorn"; } else { zodiacSign = "Aquarius"; }
                    break;
                case 2:
                    if (day < NINETEEN) { zodiacSign = "Aquarius"; } else { zodiacSign = "Fish"; }
                    break;
                case 3:
                    if (day < TWENTYONE) { zodiacSign = "Fish"; } else { zodiacSign = "Aries"; }
                    break;
                case 4:
                    if (day < TWENTY) { zodiacSign = "Aries"; } else { zodiacSign = "Taurus"; }
                    break;
                case 5:
                    if (day < TWENTYONE) { zodiacSign = "Taurus"; } else { zodiacSign = "Twins"; }
                    break;
                case 6:
                    if (day < TEWNTYTWO) { zodiacSign = "Twins"; } else { zodiacSign = "Cancer"; }
                    break;
                case 7:
                    if (day < TWENTYTHREE) { zodiacSign = "Cancer"; } else { zodiacSign = "Lion"; }
                    break;
                case 8:
                    if (day < TWENTYTHREE) { zodiacSign = "Lion"; } else { zodiacSign = "Maid"; }
                    break;
                case 9:
                    if (day < TWENTYTHREE) { zodiacSign = "Maid"; } else { zodiacSign = "Scales"; }
                    break;
                case 10:
                    if (day < TWENTYTHREE) { zodiacSign = "Scales"; } else { zodiacSign = "Scorpio"; }
                    break;
                case 11:
                    if (day < TWENTYTHREE) { zodiacSign = "Scorpio"; } else { zodiacSign = "Sagittarius"; }
                    break;
                case 12:
                    if (day < TEWNTYTWO) { zodiacSign = "Sagittarius"; } else { zodiacSign = "Capricorn"; }
                    break;
                default:
                    OutputService.ShowMessage("Error, incorrect data");
                    break;
            }
            return zodiacSign;
        }
        public static string IndividualB9(int number)
        {
            Dictionary<int, string> dictYears = new Dictionary<int, string>
            {
                { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"}, { 5, "five" }, { 6, "six" }, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
                { 10, "ten"}, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen"}, { 14, "fourteen"}, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen"}, { 18, "eighteen"}, { 19, "nineteen"},
                { 20, "twenty"}, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" }, { 60, "sixty"}, { 70, "seventy" }, { 80, "eighty" }, { 90, "ninety" }, { 100, "hundred" }
            };
            const int HUNDRED = 100,
                TWENTY = 20,
                TEN = 10,
                ZERO = 0;
            string resValue = "";
            if (number / HUNDRED > ZERO && number / HUNDRED < TEN)// from 100 to 999
            {
                int hundreds = number / HUNDRED;
                int remains = number % HUNDRED;
                resValue += dictYears[hundreds] + " " + dictYears[HUNDRED];
                if (remains / TEN > ZERO && remains > TWENTY)// from 20 to 100
                {
                    int ten = remains / TEN;
                    int digit = remains % TEN;
                    resValue += " " + dictYears[ten * TEN] + " " + dictYears[digit];
                }
                else if (remains >= ZERO)// from 0 to 20
                {
                    resValue += " " + dictYears[remains];
                }
                else
                {
                    throw new Exception("Error, program was broken.Transfer number from 0 to 999");
                }
            }
            else if (number / TEN > ZERO && number > TWENTY)// from 20 to 100
            {
                int tens = number / TEN;
                int digit = number % TEN;
                resValue = dictYears[tens * TEN] + " " + dictYears[digit];
            }
            else if (number >= ZERO)// from 0 to 20
            {
                resValue = dictYears[number];
            }
            else
            {
                throw new Exception("Error, program was broken.Transfer number from 0 to 999");
            }
            return resValue;
        }
    }
}
