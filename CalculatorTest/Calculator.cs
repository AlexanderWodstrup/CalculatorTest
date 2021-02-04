using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a,double b)
        {
            var result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {

            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Divide(double dividend, double divisor)
        {
            return dividend;
        }


    }
}