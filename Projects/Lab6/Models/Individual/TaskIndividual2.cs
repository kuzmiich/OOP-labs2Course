using Lab6.Interfaces;
using Lab6.Utils;
using Lab6.Views;
using System;
using System.Linq;

namespace Lab6.Models.Individual
{
    class TaskIndividual2 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "The maximum element of the vector and the sum of the elements of the vector located up to the last positive element.";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            const int arrSize = 10;
            var arr = extractor.GetRandomDoubleIEnumerable(arrSize).ToArray();

            OutputService.ConvertIEnumerableToString(arr);

            taskResult = $"Max number in the vector = { arr.Max() }\n" +
                         $"Sum elements before last positive = { Math.Round(SumElementsBeforeLastPositive(arr), 2) }";

            return taskResult;
        }
        public static double SumElementsBeforeLastPositive(double[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr), "Source array was null");
            }
            if (arr.Length == 0)
            {
                throw new ArgumentException("Source array was empty");
            }
            var maxLast = arr.LastOrDefault(x => x > 0);
            return arr[0..(Array.IndexOf(arr, maxLast))].Sum();
        }
    }
}
