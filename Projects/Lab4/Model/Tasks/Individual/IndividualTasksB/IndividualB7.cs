using Lab4.Utils;
using Lab4.Utils.MyConverter;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB7
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            const int Zero = 0,
                One = 1,
                Two = 2;
            int[] arrValue = extract.IndividualB7();
            char operation = Converter.ConvertToChar(arrValue[Zero]);
            int number1 = arrValue[One],
                number2 = arrValue[Two];
            return IndividualTaskB7(operation, number1, number2);
        }
        public static string IndividualTaskB7(char operation, int number1, int number2)
        {
            const char Plus = '+',
                Minus = '-',
                Pow = '*',
                Division = '/',
                DivisionRemainder = '%';
            double resNumber = 0;
            switch (operation)
            {
                case Plus:
                    resNumber = number1 + number2;
                    break;
                case Minus:
                    resNumber = number1 - number2;
                    break;
                case Pow:
                    resNumber = number1 * number2;
                    break;
                case Division:
                    try
                    {
                        resNumber = number1 / number2;
                    }
                    catch (DivideByZeroException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    break;
                case DivisionRemainder:
                    try
                    {
                        resNumber = number1 % number2;
                    }
                    catch (DivideByZeroException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    break;
                default:
                    break;
            }
            return resNumber.ToString();
        }
    }
}
