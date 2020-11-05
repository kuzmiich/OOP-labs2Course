using System;
using Lab4.Utils;
using Lab4.Views;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA1
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
        // Individual A1
        private static bool IsTriangle(double a, double b, double c)
        {
            if (c > a && a > b && c < a + b && c > a - b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string IndividualTaskA1(double aSide, double bSide, double cSide)
        {
            const double ZERO = 0;
            if (aSide < ZERO || bSide < ZERO || cSide < ZERO)
            {
                throw new Exception("Error, incorrect data.Transfer number more than 0");
            }
            return "Is these sides are sides of a triangle - " + IsTriangle(aSide, bSide, cSide);
        }
    }
}