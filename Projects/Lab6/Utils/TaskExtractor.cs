﻿using Lab7.Views;
using System;
using System.Collections.Generic;

namespace Lab7.Utils
{
    public class TaskExtractor
    {
        private readonly Random _random;
        private readonly IOutputService _outputService;
        private readonly IInputService _inputService;
        public TaskExtractor(IOutputService outputService, IInputService inputService)
        {
            _outputService = outputService;
            _inputService = inputService;
            _random = new Random();
        }

        public bool GetNumber(out int number, string message)
        {
            _outputService.ShowMessage(message);
            return int.TryParse(_inputService.GetString(), out number);
        }
        public IEnumerable<double> GetRandomDoubleIEnumerable(int count)
        {
            var resArr = new double[count];
            const int MAX = 10, MIN = -10;
            for (var i = 0; i < count; i++)
            {
                resArr[i] = Math.Round(_random.NextDouble() * (MAX - MIN) + MIN, 2);
            }
            return resArr;
        }
        public bool GetNumber(out int number, IEnumerable<string> messages)
        {
            foreach (var message in messages)
            {
                _outputService.ShowMessage(message);
            }
            return int.TryParse(_inputService.GetString(), out number);
        }
    }
}
