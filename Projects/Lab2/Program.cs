using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Data types in C#";
            List<IWrappedPrimitiveInfo> wrappedPrimitives = new List<IWrappedPrimitiveInfo>()
            {
                new WrappedBool(),
                new WrappedSbyte(),
                new WrappedByte(),
                new WrappedChar(),
                new WrappedUshort(),
                new WrappedShort(),
                new WrappedInt(),
                new WrappedUint(),
                new WrappedUlong(),
                new WrappedLong(),
                new WrappedFloat(),
                new WrappedDouble(),
                new WrappedDecimal(),
                new WrappedObject(),
                new WrappedString(),

            };
            ShowTypeInfoService.ShowTypeCollectionInfo(wrappedPrimitives);
        }
    }

    //+-*/%| || & && ^ ? ?? !~~ = == != += -= *= /= %= => () <- -> ++ --  as instanceOf() GetType() typeof
    //byte short char int float double decimal bool long
    public static class ShowTypeInfoService
    {
        public static void PrintConsole<T>(T value)
        {
            Console.WriteLine(value);
        }
        public static void ShowTypeInfo<T>(T type) where T : IWrappedPrimitiveInfo
        {
            PrintConsole(type.GetMainTypeInfo());
        }
        public static void ShowTypeCollectionInfo<T>(T typeCollection) where T : IEnumerable<IWrappedPrimitiveInfo>
        {
            foreach (var type in typeCollection)
            {
                ShowTypeInfo(type);
            }
        }
    }
}