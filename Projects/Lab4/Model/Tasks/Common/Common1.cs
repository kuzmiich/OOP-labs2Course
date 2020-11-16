using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Common
{
    public class Common1 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return CommonTask1(extract.Common1());
        }
        public string GetInfo() 
        {
            return "Count of dragon heads and eyes:";
        }
        private static int countEyes(int head)
        {
            return head * 2;
        }
        private static int countHead(int year)
        {
            int startHead = 3, CoefUpTwoHundred = 3, CoefUpTreeHundred = 2;

            int head = 0;
            if (year < 200 && year > 0)
            {
                head = year * CoefUpTwoHundred + startHead;
            }
            else if (year >= 200 && year < 300)
            {
                head = 200 * CoefUpTwoHundred + (year - 200) * CoefUpTreeHundred + startHead;
            }
            else if (year >= 300)
            {
                head = 200 * CoefUpTwoHundred + (300 - 200) * CoefUpTreeHundred + (year - 300) + startHead;
            }
            else
            {
                throw new ArgumentException("Error, incorrect data, input number more than 0.");
            }
            return head;
        }
        // Define count of dragon heads and eyes
        public static string CommonTask1(int year)
        {
            var head = countHead(year);
            return $"Count heads = {head}, count eyes = {countEyes(head)}";
        }
    }
}
