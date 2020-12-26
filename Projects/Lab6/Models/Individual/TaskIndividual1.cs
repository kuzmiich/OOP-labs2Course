using Lab5.Interfaces;
using Lab5.Utils;
using Lab5.Views;
using System;
using System.Linq;

namespace Lab5.Models.Individual
{
    class TaskIndividual1 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "The sum of the negative elements of the vector and the product of the elements of the vector located between the maximum and minimum elements.";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            var arr = extractor.GetRandomDoubleIEnumerable(10).ToArray();

            taskResult = 
                $"{OutputService.ConvertIEnumerableToString(arr)} \nThe sum of the negative elements =" +
                $"{FindSumNegativeElements(arr)}\n" +
                $"The product of the elements of the vector located between the maximum and minimum elements. =" +
                $"{FindElementBetweenMaxAndMin(arr)}";
            return taskResult;
        }

        public static double FindElementBetweenMaxAndMin(double[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr), "Source array was null");
            }
            if (arr.Length == 0)
            {
                throw new ArgumentException("Source array was empty");
            }
            var range = Array.IndexOf(arr, arr.Min())..Array.IndexOf(arr, arr.Max());

            return arr[range].Aggregate((p, x) => p *= x);
        }
        public static double FindSumNegativeElements(double[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr), "Source array was null");
            }
            if (arr.Length == 0)
            {
                throw new ArgumentException("Source array was empty");
            }
            return arr.Where(el => el < 0).Sum();
        }
    }
}
