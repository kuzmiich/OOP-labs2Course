﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Lab3
{ 
    public class WrappedPrimitive<T> : IOperationInfo where T : struct
    {

        public T ValueOne { get; set; } = default;
        public T ValueTwo { get; set; } = default;

        public WrappedPrimitive(T one, T two)
        {
            ValueOne = one;
            ValueTwo = two;
        }
        public WrappedPrimitive() { }
        public Func<string>[] GetFuncsWithOperationStringResult()
        {
            
            int amount = 50;
            string splitter = "=";
            Type type = typeof(T);
            Program.Center(amount, $"Type = {type.Name}", splitter);
            Func<string>[] actions = new Func<string>[]
            {
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "+", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 + c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "-", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 - c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "*", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 * c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "/", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 / c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "%", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 % c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "&", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 & c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "|", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 | c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "&&", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 && c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "||", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 || c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "??", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 ?? c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "^", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 ^ c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, ">", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 > c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "<", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 < c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "<=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 <= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, ">=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 >= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "==", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 == c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "!=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 != c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, ">>", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 >> c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "<<", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 << c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 = c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "+=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 += c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "-=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 -= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "*=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 *= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "/=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 /= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "%=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 %= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, ">>=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 >>= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "<<=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 <<= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "&=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 &= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "|=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 |= c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "??=", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 ??= c2)),
                () => GetStringTernary(ValueOne, ValueTwo),
                () => GetStringUnaryOperator(ValueOne, "~", new Func<dynamic, dynamic>((c1) => ~c1)),
                () => GetStringUnaryOperator(ValueOne, "!", new Func<dynamic, dynamic>((c1) => !c1)),
                () => GetStringUnaryOperator(ValueOne, "++", new Func<dynamic, dynamic>((c1) => ++c1)),
                () => GetStringUnaryOperator(ValueOne, "++", new Func<dynamic, dynamic>((c1) => c1++), IsPostFix:true),
                () => GetStringUnaryOperator(ValueOne, "--", new Func<dynamic, dynamic>((c1) => --c1)),
                () => GetStringUnaryOperator(ValueOne, "--", new Func<dynamic, dynamic>((c1) => c1--), IsPostFix:true),
                () => $"default(T) = {default(T)}",
                () => $"GetType() = {ValueOne.GetType()}",
                () => $"c1 is dynamic = {ValueOne is dynamic}",
                () => $"c2 is object = {ValueOne is object}",
                () => $"c2 is int = {ValueOne is int}",
                () => $"c1 as object = {ValueOne as object ?? "Not Succesfull"}",
            };
            return actions;
        }
        public static string GetStringTernary(dynamic c1, dynamic c2) => $"c1 > c2 ? true : false = {(c1 > c2 ? true : false)}";

        public static string GetStringBinaryOperator(dynamic c1, dynamic c2, string opStrRepr, Func<dynamic, dynamic, dynamic> func)
        {
            return $"{c1} {opStrRepr} {c2} = {func?.Invoke(c1, c2)}";
        }

        public static string GetStringUnaryOperator(dynamic c1, string opStrRepr, Func<dynamic, dynamic> func, bool IsPostFix = false)
        {
            return IsPostFix? $"{c1}{opStrRepr} = {func?.Invoke(c1)}": $"{opStrRepr}{c1} = {func?.Invoke(c1)}";
        }
    }

}
