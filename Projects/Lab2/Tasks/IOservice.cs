﻿using System;

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
