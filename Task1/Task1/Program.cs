using System;
using System.Text;

namespace Task1
{
    public delegate double MathFunction(double x);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Введіть значення x: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Потрібно було ввести число");
                return;
            }
            if (double.TryParse(input, out double x))
            {
                MathFunction calculationMethod;
                if (x > 0)
                {
                    calculationMethod = CalculatePositive;
                }
                else
                {
                    calculationMethod = CalculateNonPositive;
                }
                double result = calculationMethod(x);

                Console.WriteLine($"Результат F({x}) = {result:F4}");
            }
            else
            {
                Console.WriteLine("Потрібно було ввести число");
            }
        }
        static double CalculatePositive(double x)
        {
            return Math.Cos(x + 1);
        }
        static double CalculateNonPositive(double x)
        {
            return 1 - 2 * Math.Sin(x);
        }
    }
}