using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA1 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            const int Zero = 0, One = 1, Two = 2;
            double[] arrValue = extract.IndividualA1();
            double aSide = arrValue[Zero];
            double bSide = arrValue[One];
            double cSide = arrValue[Two];
            return IndividualTaskA1(aSide, bSide, cSide);
        }
        public string GetInfo()
        {
            return "Determines whether the given sides are sides of a triangle.";
        }
        // Individual A1
        //TODO FIX LOGIC
        private static bool IsTriangle(double a, double b, double c)
        {
            return c > a && a > b && c < a + b && c > a - b;
        }
        public static string IndividualTaskA1(double aSide, double bSide, double cSide)
        {
            const double Zero = 0;
            if (aSide < Zero || bSide < Zero || cSide < Zero)
            {
                throw new Exception("Error, incorrect data.Transfer number more than 0");
            }
            return "Is these sides are sides of a triangle - " + IsTriangle(aSide, bSide, cSide);
        }
    }
}