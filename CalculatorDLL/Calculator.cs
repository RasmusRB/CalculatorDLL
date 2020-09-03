using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDLL
{
    public class Calculator
    {
        /// <summary>
        /// Returns sum of numbers in basic math functions with integers (add, subtract, multiply, divide)
        /// Methods must be static to call the method on the class in the unittest and class public.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {

            return a - b;
        }

        public static int Multiplication (int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Returns sum of numbers in basic math functions with doubles (add, subtract, multiply, divide)
        /// Methods must be static to call the method on the class in the unittest and class public.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
