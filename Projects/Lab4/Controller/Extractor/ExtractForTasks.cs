using System;
using Lab4.Views;
using Lab4.Model.MyConverter;

namespace Lab4.Controller.Extractor
{
    class ExtractForTasks : IExtractForTasks
    {
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
            Random rand = new Random();
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
            Random rand = new Random();
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
            Random rand = new Random();
            int indexAdvantage = rand.Next(4);
            int indexSuits = rand.Next(8);
            return 1;
        }
        public int IndividualB4()
        {
            Random rand = new Random();
            int countNumbers = 120;
            return rand.Next(countNumbers);
        }
        public int IndividualB5()
        {
            return 1;
        }
        public int IndividualB6()
        {
            return 1;
        }
        public int IndividualB7()
        {
            return 1;
        }
        public int[] IndividualB8()
        {
            OutputService.ShowMessage("Input date:");
            int day = Converter.ConvertToInt(InputService.InputString());
            OutputService.ShowMessage("Input mounth:");
            int mounth = Converter.ConvertToInt(InputService.InputString());
            int[] arrDate = { day, mounth };
            return arrDate;
        }
        public int IndividualB9()
        {
            OutputService.ShowMessage("");
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
