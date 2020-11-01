using System;
using System.Collections.Generic;
using Lab4.Model.MyConverter;
using Lab4.Views;

namespace Lab4.Model.Tasks.Additional
{
    class AdditionalTasks
    {
        public static string Additional1()
        {
            int day = Converter.ConvertToInt(InputService.GetUserInputStr());
            int mount = Converter.ConvertToInt(InputService.GetUserInputStr());
            int year = Converter.ConvertToInt(InputService.GetUserInputStr());

            return "";
        }
    }
}
