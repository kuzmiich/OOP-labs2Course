using System;
using System.Collections.Generic;
using Lab4.Utils;
using Lab4.Views;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB1
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB1(extract.IndividualB1());
        }
        public static string IndividualTaskB1(int dayOfWeek)
        {
            List<string> listDayOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            const int StartRange = 1, EndRange = 7, One = 1;

            if (dayOfWeek >= StartRange && dayOfWeek <= EndRange)
            {
                return $"Today is - {listDayOfWeek[dayOfWeek - One]}";
            }
            else
            {
                throw new Exception("Error, incorrect data.Transfer number from 1 to 7");
            }
        }
    }
}
