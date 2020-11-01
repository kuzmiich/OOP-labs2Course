using System;
using Lab4.Views;

namespace Lab4.Model.MyConverter
{
    public class Converter : IConverter
    {
        public static int ConvertToInt(string value)
        {
            int res = 0;
            try
            {
                res = Convert.ToInt32(value);
            }
            catch (FormatException ex)
            {
                OutputService.ShowMessage(ex.Message);
            }
            return res;
        }
        public static uint ConvertToUInt(string value)
        {
            uint res = 0;
            try
            {
                res = Convert.ToUInt32(value);
            }
            catch (FormatException ex)
            {
                OutputService.ShowMessage(ex.Message);
            }
            return res;
        }
        public static double ConvertToDouble(string value)
        {
            double res = 0;
            try
            {
                res = Convert.ToDouble(value);
            }
            catch (FormatException ex)
            {
                OutputService.ShowMessage(ex.Message);
            }
            return res;
        }
    }
}
