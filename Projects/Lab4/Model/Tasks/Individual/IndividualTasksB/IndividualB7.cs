﻿using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Utils.MyConverter;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB7 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());

            int[] arrValue = extract.IndividualB7();
            string operation = arrValue[0].ToString();
            int number1 = arrValue[1],
                number2 = arrValue[2];
            return IndividualTaskB7(operation, number1, number2);
        }
        public string GetInfo()
        {
            return "A program that accepts an operation and two real numbers from the user, and then performs the specified action on these numbers and outputs the result";
        }
        //TODO Replace with Dictionary<string, Func<int,int,string>>
        public static string IndividualTaskB7(string operation, int number1, int number2)
        {
            const string PLUS = "+",
                MINUS = "-",
                POW = "*",
                DIVISION = "/",
                DIVISION_REMAINDER = "%";
            double resNumber = 0;
            switch (operation)
            {
                case PLUS:
                    resNumber = number1 + number2;
                    break;
                case MINUS:
                    resNumber = number1 - number2;
                    break;
                case POW:
                    resNumber = number1 * number2;
                    break;
                case DIVISION:
                     resNumber = number1 / number2;
                    break;
                case DIVISION_REMAINDER:
                    resNumber = number1 % number2;
                    break;
                default:
                    break;
            }
            return resNumber.ToString();
        }
    }
}
