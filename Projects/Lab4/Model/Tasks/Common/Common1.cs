using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Common
{
    public class Common1 : ITask
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return CommonTask1(extract.Common1());
        }
        // Define count of dragon heads and eyes
        public static string CommonTask1(int year)
        {
            const int startHead = 3, CoefUpTwoHundred = 3, CoefUpTreeHundred = 2;
            const int zeroYear = 0, TwoHundredYear = 200, TreeHundredYear = 300;

            int head;
            if (year < TwoHundredYear && year > zeroYear)
            {
                head = year * CoefUpTwoHundred + startHead;
            }
            else if (year >= TwoHundredYear && year < TreeHundredYear)
            {
                head = TwoHundredYear * CoefUpTwoHundred + (year - TwoHundredYear) * CoefUpTreeHundred + startHead;
            }
            else if (year >= TreeHundredYear)
            {
                head = TwoHundredYear * CoefUpTwoHundred + (TreeHundredYear - TwoHundredYear) * CoefUpTreeHundred + (year - TreeHundredYear) + startHead;
            }
            else
            {
                throw new Exception("Error, incorrect data, input number more than 0.");
            }
            int eyes = head * 2;
            return $"Count heads = {head}, count eyes = {eyes}";
        }
    }
}
