using System;
using System.IO;

namespace calc_multi
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Multiply two input numbers");
            Console.Write("Enter first number here: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number here: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = a * b;
            Console.WriteLine($"The result of {a} * {b} is: {c}");

            Convert.ToString(a);
            Convert.ToString(b);
            Convert.ToString(c);

            string result = $"a = {a}\nb = {b}\nc = {c}";
            File.WriteAllText("calc.txt", result);
        }
    }
}