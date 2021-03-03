using System;


namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculator uut = new Calculator.Calculator();

            Console.WriteLine($"Test af Add funktion, 5 + 5 = {uut.Add(5,5)}");

            Console.WriteLine("Test af Add funktion, " + uut.Accumulator + $" + 5 = {uut.Add(5)}");

            Console.WriteLine($"Test af Subtract funktion, 7 - 3 = {uut.Subtract(7,3)}");

            Console.WriteLine($"Test af Multiply funktion, 6 * 6 = {uut.Multiply(6,6)}");

            Console.WriteLine($"Test af Power funktion, 4 ^ 2 = {uut.Power(4,2)}");
        }
    }

    //Palle was here
    //Alex was here too
    //testing agian
}
