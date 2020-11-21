using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;

namespace Lab4.Model.Tasks.Additional
{
    class Additional1 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            int[] arrValue = extract.Additional1();
            int day = arrValue[0],
                mounth = arrValue[1],
                year = arrValue[2];
            return AdditionalTask1(day, mounth, year);
        }
        public string GetInfo()
        {
            return "Specifies the date of the next day:";
        }
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
        public static string AdditionalTask1(int day, int mounth, int year)
        {
            int[] arrCountDayInMounth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            const int COUNT_MOUNTH = 12;
            if (IsLeep(year))
            {
                arrCountDayInMounth[1]++;
            }
            int i;
            for (i = 0; i < COUNT_MOUNTH; i++)
            {
                if (++i == mounth && day == arrCountDayInMounth[i])
                {
                    day = 1;
                    mounth++;
                    break;
                }
            }
            if (i == COUNT_MOUNTH)
            {
                day++;
            }
            else if (mounth == COUNT_MOUNTH + 1)
            {
                mounth = 1;
                year++;
            }
            return $"{day} {mounth} {year}";
        }
    }
}
