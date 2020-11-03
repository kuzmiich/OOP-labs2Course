using System;
using System.Collections.Generic;
using Lab4.Model.MyConverter;
using Lab4.Views;

namespace Lab4.Model.Tasks.Additional
{
    static class AdditionalTasks
    {
        private static bool IsLeep(int year)
        {
            const int ZERO = 0,
                FOUR = 4,
                HUNDRED = 100,
                FOURHUNDRED = 400;
            bool isLeep = false;
            // leep
            if (year % FOUR == ZERO)
            {
                isLeep = true;
            }
            // not leep
            else if (year % FOUR == ZERO && year % HUNDRED == ZERO)
            {
                isLeep = false;
            }
            // leep
            else if (year % FOUR == ZERO && year % HUNDRED == ZERO && year % FOURHUNDRED == ZERO)
            {
                isLeep = true;
            }
            return isLeep;
        }
        public static string Additional(int day, int mounth, int year)//fix
        {
            int[] arrCountDayInMounth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            const int TWELVE = 12, ONE = 1;

            if (IsLeep(year))
            {
                arrCountDayInMounth[ONE]++;
            }

            int i;
            for (i = 0; i < TWELVE; i++)
            {
                if (++i == mounth & day == arrCountDayInMounth[i])
                {
                    day = ONE;
                    mounth++;
                    break;
                }
            }
            if (i == TWELVE)
            {
                day++;
            }
            if (mounth == TWELVE + ONE)
            {
                mounth = ONE;
                year++;
            }
            return day + " " + mounth + " " + year;
        }
    }
}
