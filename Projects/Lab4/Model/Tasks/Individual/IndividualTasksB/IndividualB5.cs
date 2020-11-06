using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB5 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            const int Zero = 0,
                One = 1;
            uint[] arrValue = extract.IndividualB5();
            uint year = arrValue[Zero],
                mounth = arrValue[One];
            return IndividualTaskB5(year, mounth);
        }
        public string GetInfo()
        {
            return "Defines the number of days in this month for a non-leap year:";
        }
        // count of day in mount for not a leap year
        private static bool IsLeep(uint year)
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
        public static string IndividualTaskB5(uint mounth, uint year)
        {
            uint[] arrCountDayInMounth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string resData = "";
            if (IsLeep(year))
            {
                resData = "Year is leep!";
            }
            else
            {
                resData = $"In {mounth} mounth - { arrCountDayInMounth[--mounth] } days";
            }
            return resData;
        }
    }
}
