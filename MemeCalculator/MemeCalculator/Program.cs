using System;
using System.Collections.Generic;
using System.Linq;

namespace MemeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> seq = Enumerable.Range(-1000, 2000);

            Dictionary<string, string> addition = new Dictionary<string, string>();
            Dictionary<string, string> substraction = new Dictionary<string, string>();
            Dictionary<string, string> multiplication = new Dictionary<string, string>();
            Dictionary<string, string> division = new Dictionary<string, string>();

            foreach (var number in seq)
            {
                var a = number;
                foreach (var num in seq)
                {
                    var result = a + num;
                    var operation = a.ToString() + "+" + num.ToString();
                    addition.Add(operation, result.ToString());
                }
            }

            foreach (var number in seq)
            {
                var a = number;
                foreach (var num in seq)
                {
                    var result = a - num;
                    var operation = a.ToString() + "-" + num.ToString();
                    substraction.Add(operation, result.ToString());
                }
            }

            foreach (var number in seq)
            {
                var a = number;
                foreach (var num in seq)
                {
                    var result = a * num;
                    var operation = a.ToString() + "*" + num.ToString();
                    multiplication.Add(operation, result.ToString());
                }
            }

            foreach (var number in seq)
            {
                var a = number;
                foreach (var num in seq)
                {
                    if (num != 0)
                    {
                        double result = Convert.ToDouble(a) / Convert.ToDouble(num);
                        var operation = a.ToString() + "/" + num.ToString();
                        division.Add(operation, result.ToString());
                    }
                }
            }

            int firstValue;
            int secondValue;
            string mathOperator;

            Console.WriteLine("Welcome to the MemeCalculator!");
            Console.WriteLine();
            Console.Write("Enter the first number: ");
            firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operator: ");
            mathOperator = Console.ReadLine();
            Console.Write("Enter the second number: ");
            secondValue = Convert.ToInt32(Console.ReadLine());

            string calcInput = firstValue.ToString() + mathOperator + secondValue.ToString();
            string outcome;
            try
            {
                outcome = addition[calcInput];
                Console.WriteLine(calcInput + "=" + outcome);
            }
            catch (Exception)
            {
            }

            try
            {
                outcome = substraction[calcInput];
                Console.WriteLine(calcInput + "=" + outcome);
            }
            catch (Exception)
            {
            }

            try
            {
                outcome = multiplication[calcInput];
                Console.WriteLine(calcInput + "=" + outcome);
            }
            catch (Exception)
            {
            }

            try
            {
                outcome = division[calcInput];
                Console.WriteLine(calcInput + "=" + outcome);
            }
            catch (Exception)
            {
            }
        }
    }
}
