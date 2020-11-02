using System;
using Lab4.Views;
using Lab4.Model.MyConverter;

namespace Lab4.Controller.Extractor
{
    class ExtractForTasks : IExtractForTasks
    {
        Random rand = new Random();
        public ExtractForTasks()
        {
        }
        public int Common()
        {
            OutputService.ShowMessage("Input count of heads: ");
            return Converter.ConvertToInt(InputService.InputString());
        }
        public int[] Common2()
        {
            OutputService.ShowMessage("Fill in the array of numbers:");
            return Converter.ConvertToArrayInt(InputService.InputString());;
        }
        public int Common3()
        {
            OutputService.ShowMessage("Input number: ");
            return Converter.ConvertToInt(InputService.InputString());
        }
        public double[] IndividualA()
        {
            Console.WriteLine("Input 3 sides: ");
            double a = Converter.ConvertToDouble(InputService.InputString());
            double b = Converter.ConvertToDouble(InputService.InputString());
            double c = Converter.ConvertToDouble(InputService.InputString());
            double[] arrSides = { a, b, c };
            return arrSides;
        }
        // возможна цифра при вводе - надо переделать
        public char IndividualA2()
        {
            Console.WriteLine("Input letter: ");
            return InputService.GetUserInputLetter();
        }
        //
        public int IndividualA3()
        {
            OutputService.ShowMessage("The mood of the user:\n");
            return rand.Next(100);
        }
        public int[] IndividualA4()
        {
            OutputService.ShowMessage("Roll the dice:\n");
            Random rand = new Random();
            int countPoint = 6;
            int firstDie = rand.Next(countPoint);
            int secondDie = rand.Next(countPoint);
            int[] arrDies = { firstDie, secondDie };
            return arrDies;
        }
        public int IndividualA5()
        {
            int countSurprise = 8;
            return rand.Next(countSurprise);
        }
        public int IndividualB()
        {
            OutputService.ShowMessage("Input number from 1 to 7:");
            return Converter.ConvertToInt(InputService.InputString());
        }
        public int IndividualB2()
        {
            OutputService.ShowMessage("Input number from 0 to 10:");
            return Converter.ConvertToInt(InputService.InputString());
        }
        public int IndividualB3()
        {
            int indexAdvantage = rand.Next(4);
            int indexSuits = rand.Next(8);
            return 1;
        }
        public int IndividualB4()
        {
            int countNumbers = 120;
            return rand.Next(countNumbers);
        }
        public uint[] IndividualB5()
        {
            OutputService.ShowMessage("Input number Mounth:");
            uint numberMounth = Converter.ConvertToUInt(InputService.InputString());
            OutputService.ShowMessage("Input number Year:");
            uint numberYear = Converter.ConvertToUInt(InputService.InputString());
            uint[] arrDate = { numberMounth, numberYear };
            return arrDate;
        }
        public int IndividualB6()
        {
            OutputService.ShowMessage("Input operation and two numbers:");
            return Converter.ConvertToInt(InputService.InputString());
        }
        public int[] IndividualB7()
        {
            OutputService.ShowMessage("Input operation and two numbers:");
            char operation = InputService.GetUserInputLetter();
            int number1 = Converter.ConvertToInt(InputService.InputString());
            int number2 = Converter.ConvertToInt(InputService.InputString());
            int[] arrDate = { operation, number1, number2 };
            return arrDate;
        }
        public int[] IndividualB8()
        {
            OutputService.ShowMessage("Input date:");
            int day = Converter.ConvertToInt(InputService.InputString());
            OutputService.ShowMessage("Input mounth:");
            int mounth = Converter.ConvertToInt(InputService.InputString());
            int[] arrData = { day, mounth };
            return arrData;
        }
        public int IndividualB9()
        {
            OutputService.ShowMessage("Input number:");
            return Converter.ConvertToInt(InputService.InputString());
        }
        public int[] Additional()
        {
            int day = Converter.ConvertToInt(InputService.InputString());
            int mounth = Converter.ConvertToInt(InputService.InputString());
            int year = Converter.ConvertToInt(InputService.InputString());
            int[] arrSides = { day, mounth, year };
            return arrSides;
        }
    }
}
