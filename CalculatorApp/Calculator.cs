using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CalculatorApp
{
    public static class Calculator
    {
        public static int Multiply(int a, int b) => a * b;
        public static int Add(int a, int b) => a + b;

        // Деление двух чисел с проверкой деления на ноль.

        public static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Деление на ноль невозможно");

            return a / b;
        }
    }
}
