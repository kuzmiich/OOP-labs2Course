﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Tasks
{
   public static class IOservice
   {
        public static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string GetUserInputStr()
        {
            return Console.ReadLine();
        }
   }
}
