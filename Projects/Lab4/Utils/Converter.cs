using System;
using Lab4.Views;

namespace Lab4.Utils.MyConverter
{
    public class Converter : IConverter
    {
        public static int[] ConvertToArrayInt(string value)
        {
            int[] res;
            try
            {
                res = Array.ConvertAll(value.Split(), int.Parse);
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message);
            }
            return res;
        }
        public static int ConvertToChar(char letter)
        {
            char res = ' ';
            try
            {
                res = Convert.ToChar(letter);
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message);
            }
            return res;
        }
        public static char ConvertToChar(int letter)
        {
            char res;
            try
            {
                res = Convert.ToChar(letter);
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message);
            }
            return res;
        }
        public static int ConvertToInt(string value)
        {
            int res = 0;
            try
            {
                res = Convert.ToInt32(value);
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message);
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
                throw new FormatException(ex.Message);
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
                throw new FormatException(ex.Message);
            }
            return res;
        }
    }
}
