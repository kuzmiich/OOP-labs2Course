using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB6
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB6(extract.IndividualB6());
        }
        public static string IndividualTaskB6(int numberMounth)
        {
            Dictionary<int, string> mounthDict = new Dictionary<int, string>
            {
                { 1, "January" }, { 2, "February" }, { 3, "March" }, { 4, "April"}, { 5, "May"}, { 6, "June" },
                { 7, "July" }, { 8, "August"}, { 9, "September"}, { 10, "October"}, { 11, "November"}, { 12, "December"}
            };
            const int One = 1,
                Three = 3,
                Six = 6,
                Nine = 9,
                Twelve = 12;
            string resTimeYear = "";
            if (numberMounth >= One && numberMounth < Three || numberMounth == Twelve)
            {
                resTimeYear = "Winter";
            }
            else if (numberMounth >= Three && numberMounth < Six)
            {
                resTimeYear = "Spring";
            }
            else if (numberMounth >= Six && numberMounth < Nine)
            {
                resTimeYear = "Summer";
            }
            else if (numberMounth >= Nine && numberMounth < Twelve)
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
