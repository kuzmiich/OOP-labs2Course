using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Tasks
{
    public static class Converter
    {
        public static double GetConvertionResult(double grams, int coef)
        {
            return grams / coef;
        }
    }
}
