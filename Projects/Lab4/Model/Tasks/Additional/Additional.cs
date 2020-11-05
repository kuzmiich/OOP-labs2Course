using Lab4.Utils;
using Lab4.Views;

namespace Lab4.Model.Tasks.Additional
{
    class Additional
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            const int Zero = 0,
                One = 1,
                Two = 2;
            int[] arrValue = extract.Additional1();
            int day = arrValue[Zero],
                mounth = arrValue[One],
                year = arrValue[Two];
            return AdditionalTask1(day, mounth, year);
        }
        private static bool IsLeep(int year)
        {
            const int Zero = 0,
                Four = 4,
                Hundred = 100,
                FourHundred = 400;
            bool isLeep = false;
            // leep
            if (year % Four == Zero)
            {
                isLeep = true;
            }
            // not leep
            else if (year % Four == Zero && year % Hundred == Zero)
            {
                isLeep = false;
            }
            // leep
            else if (year % Four == Zero && year % Hundred == Zero && year % FourHundred == Zero)
            {
                isLeep = true;
            }
            return isLeep;
        }
        public static string AdditionalTask1(int day, int mounth, int year)//fix
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
