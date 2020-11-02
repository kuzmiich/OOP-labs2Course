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
            bool isLeep = false;
            // leep
            if (year % 4 == 0)
            {
                isLeep = true;
            }
            // not leep
            else if (year % 4 == 0 && year % 100 == 0)
            {
                isLeep = false;
            }
            // leep
            else if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                isLeep = true;
            }
            return isLeep;
        }
        public static string Additional(int day, int mounth, int year)
        {
            int[] arrCountDayInMounth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int countMounth = 12, rotateToStart = 1;


            if (IsLeep(year))
            {
                arrCountDayInMounth[1]++;
            }

            int i;
            for (i = 0; i < countMounth; i++)
            {
                if (++i == mounth & day == arrCountDayInMounth[i])
                {
                    day = rotateToStart;
                    mounth++;
                    break;
                }
            }
            if (i == 12)
            {
                day++;
            }
            if (mounth == 13)
            {
                mounth = rotateToStart;
                year++;
            }
            return (day + mounth + year).ToString();
        }
    }
}
