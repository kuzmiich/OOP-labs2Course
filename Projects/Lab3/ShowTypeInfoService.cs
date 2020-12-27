using System;
using System.Collections.Generic;

namespace Lab3
{
    //+-*/%| || & && ^ ? ?? !~~ = == != += -= *= /= %= => () <- -> ++ --  as instanceOf() GetType() typeof
    //byte short char int float double decimal bool long
    public static class ShowTypeInfoService
    {
        public static void GetTypeOperationFuncsWithResultString<T>(T typeCollection) where T : IEnumerable<IOperationInfo>
        {
            foreach (var type in typeCollection)
            {
                ShowArrayWithFuncOperationsResultString(type.GetFuncsWithOperationStringResult());
            }
        }
        public static void ShowFuncOperationResultString(Func<string> func)
        {
            Console.WriteLine(func?.Invoke());
        }

        public static void ShowArrayWithFuncOperationsResultString(Func<string>[] funcs)
        {
            foreach (var func in funcs)
            {
                try
                {
                    ShowFuncOperationResultString(func);
                }
                catch (Exception ex)
                {
                    ConsoleColor defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = defaultColor;
                }
            }
        }
    }
}
