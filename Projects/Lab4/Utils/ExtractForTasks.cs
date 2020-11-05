using System;
using Lab4.Views;
using Lab4.Utils.MyConverter;

namespace Lab4.Utils
{
    class ExtractForTasks
    {
        private readonly Random rand = new Random();

        protected IInputService _inputService { get; set; }
        protected IOutputService _outputService { get; set; }

        public ExtractForTasks(IInputService inputService, IOutputService outputService)
        {
            _inputService = inputService;
            _outputService = outputService;
        }

        public int Common1()
        {
            _outputService.ShowMessage("Input count of heads: ");
            return Converter.ConvertToInt(_inputService.InputString());
        }
        public int[] Common2()
        {
            _outputService.ShowMessage("Fill in the array of numbers:");
            return Converter.ConvertToArrayInt(_inputService.InputString());;
        }
        public int Common3()
        {
            _outputService.ShowMessage("Input number: ");
            return Converter.ConvertToInt(_inputService.InputString());
        }
        public double[] IndividualA1()
        {
            _outputService.ShowMessage("Input 3 sides: ");
            double a = Converter.ConvertToDouble(_inputService.InputString());
            double b = Converter.ConvertToDouble(_inputService.InputString());
            double c = Converter.ConvertToDouble(_inputService.InputString());
            double[] arrSides = { a, b, c };
            return arrSides;
        }
        // возможна цифра при вводе - надо переделать
        public char IndividualA2()
        {
            _outputService.ShowMessage("Input day:");
            _outputService.ShowMessage("Input letter: ");
            return _inputService.GetUserInputLetter();
        }
        //
        public int IndividualA3()
        {
            _outputService.ShowMessage("The mood of the user:\n");
            return rand.Next(100);
        }
        public int[] IndividualA4()
        {
            _outputService.ShowMessage("Roll the dice:\n");
            int countPoint = 6;
            int firstDie = rand.Next(countPoint);
            int secondDie = rand.Next(countPoint);
            int[] arrDies = { firstDie, secondDie };
            return arrDies;
        }
        public int IndividualA5()
        {
            _outputService.ShowMessage("");
            int countSurprise = 8;
            return rand.Next(countSurprise);
        }
        public int IndividualB1()
        {
            _outputService.ShowMessage("Input number from 1 to 7:");
            return Converter.ConvertToInt(_inputService.InputString());
        }
        public int IndividualB2()
        {
            _outputService.ShowMessage("Input number from 0 to 10:");
            return Converter.ConvertToInt(_inputService.InputString());
        }
        public int[] IndividualB3()
        {
            _outputService.ShowMessage("");
            int indexAdvantage = rand.Next(4);
            int indexSuits = rand.Next(8);
            int[] resArr = { indexAdvantage, indexSuits };
            return resArr;
        }
        public int IndividualB4()
        {
            _outputService.ShowMessage("");
            int countNumbers = 120;
            return rand.Next(countNumbers);
        }
        public uint[] IndividualB5()
        {
            _outputService.ShowMessage("Input number mounth:");
            uint numberMounth = Converter.ConvertToUInt(_inputService.InputString());
            _outputService.ShowMessage("Input number year:");
            uint numberYear = Converter.ConvertToUInt(_inputService.InputString());
            uint[] arrDate = { numberMounth, numberYear };
            return arrDate;
        }
        public int IndividualB6()
        {
            _outputService.ShowMessage("Input operation and two numbers:");
            return Converter.ConvertToInt(_inputService.InputString());
        }
        public int[] IndividualB7()
        {
            _outputService.ShowMessage("Input operation and two numbers:");
            char operation = _inputService.GetUserInputLetter();
            int number1 = Converter.ConvertToInt(_inputService.InputString());
            int number2 = Converter.ConvertToInt(_inputService.InputString());
            int[] arrDate = { operation, number1, number2 };
            return arrDate;
        }
        public int[] IndividualB8()
        {
            _outputService.ShowMessage("Input day:");
            int day = Converter.ConvertToInt(_inputService.InputString());
            _outputService.ShowMessage("Input mounth:");
            int mounth = Converter.ConvertToInt(_inputService.InputString());
            int[] arrData = { day, mounth };
            return arrData;
        }
        public int IndividualB9()
        {
            _outputService.ShowMessage("Input number:");
            return Converter.ConvertToInt(_inputService.InputString());
        }
        public int[] Additional1()
        {
            _outputService.ShowMessage("Input day:");
            int day = Converter.ConvertToInt(_inputService.InputString());
            _outputService.ShowMessage("Input mounth:");
            int mounth = Converter.ConvertToInt(_inputService.InputString());
            _outputService.ShowMessage("Input year:");
            int year = Converter.ConvertToInt(_inputService.InputString());
            int[] arrSides = { day, mounth, year };
            return arrSides;
        }
    }
}
