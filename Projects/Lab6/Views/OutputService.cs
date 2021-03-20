﻿using Lab7.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Views
{
    public class OutputService : IOutputService
    {
        private static readonly object _syncRoot = new object();
        private static OutputService _instance;

        private OutputService()
        {

        }

        public static OutputService GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new OutputService();
                    }
                }
            }
            return _instance;
        }

        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public static string ConvertIEnumerableToString<T>(IEnumerable<T> enumerable)
        {
            var builder = new StringBuilder();
            foreach (var element in enumerable)
            {
                builder.AppendFormat("{0} ", element);
            }
            return builder.ToString();
        }
    }
}
