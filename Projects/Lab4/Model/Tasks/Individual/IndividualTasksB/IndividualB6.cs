using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB6 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB6(extract.IndividualB6());
        }
        public string GetInfo()
        {
            return "Displays the name of the corresponding time of year according to the day of the month:";
        }
        //TODO switch case
        public static string IndividualTaskB6(int numberMounth)
        {
            string resTimeYear = "";
            if (numberMounth >= 1 && numberMounth < 3 || numberMounth == 12)
            {
                resTimeYear = "Winter";
            }
            else if (numberMounth >= 3 && numberMounth < 6)
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
                throw new Exception("Error, invalid data.");
            }
            return resTimeYear;
        }
    }
}
