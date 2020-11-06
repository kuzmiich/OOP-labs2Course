using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;

namespace Lab4.Model.Tasks.Common
{
    class Common2 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return CommonTask2(extract.Common2());
        }
        public string GetInfo()
        {
            return "Determines which of the four etc. values entered by the user is the largest (smallest):";
        }
        // The Greatest
        private static bool isAllValuesEquel(int[] numbers)
        {
            bool flag = false;
            const int Zero = 0;
            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[Zero] == numbers[i])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                    // return false;
                }
            }
            return flag;
        }
        public static string CommonTask2(int[] numbers)
        {
            string resValue = "";
            const int Zero = 0;
            if (isAllValuesEquel(numbers))
            {
                resValue = "All values are equal.";
            }
            int max = numbers[Zero], min = numbers[Zero];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            resValue = $"Max = {max}, Min = {min}";
            return resValue;
        }
    }
}
