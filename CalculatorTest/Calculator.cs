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
            var result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            var result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double x, double exp)
        {
            var result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
        }
        public double Divide(double dividend, double divisor)
        {
            var result = dividend / divisor;
            Accumulator = result;
            return result;
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

        

        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            Accumulator /= divisor;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Math.Pow(Accumulator, exponent);
            return Accumulator;
        }
    }
}