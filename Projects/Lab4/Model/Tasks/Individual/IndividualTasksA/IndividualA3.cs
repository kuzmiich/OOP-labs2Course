using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA3 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskA3(extract.IndividualA3());
        }
        public string GetInfo()
        {
            return "Emulates the user's mood.Two six-sided dice (dice) are thrown and the total amount of points that fell on the first and second dice is calculated:";
        }

        //TODO Replace with constants
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
        // Individual A3 - Mood sensor
        public static string IndividualTaskA3(int mood)
        {
            string smile = "";
            const int Zero = 0,
                ThirtyThree = 33,
                SixtySix = 66;
            if (mood >= Zero && mood < ThirtyThree)
            {
                smile = BadMood();
            }
            else if (mood >= ThirtyThree && mood < SixtySix)
            {
                smile = GoodMood();
            }
            else if (mood >= SixtySix)
            {
                smile = PerfectMood();
            }
            else
            {
                throw new Exception("Error, program was broken.Transfer number from 0 to 100");
            }
            return smile;
        }
    }
}
