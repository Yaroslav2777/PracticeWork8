using System;
using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            try
            {
                Console.Write("Введіть перше число: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Помилка: Некоректне число.");
                    return;
                }

                Console.Write("Введіть операцію (+, -, *, /): ");
                string? op = Console.ReadLine();

                Console.Write("Введіть друге число: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Помилка: Некоректне число.");
                    return;
                }
                Func<double, double, double>? operation = null;
                switch (op)
                {
                    case "+":
                        operation = Add;
                        break;
                    case "-":
                        operation = Subtract;
                        break;
                    case "*":
                        operation = Multiply;
                        break;
                    case "/":
                        operation = Divide;
                        break;
                    default:
                        Console.WriteLine("Помилка: Невідома операція.");
                        return;
                }
                if (operation != null)
                {
                    double result = operation(num1, num2);
                    if (double.IsInfinity(result))
                    {
                        Console.WriteLine("Помилка: Ділення на нуль.");
                    }
                    else
                    {
                        Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка: Ділення на нуль неможливе.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка: {ex.Message}");
            }
        }
        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                return double.PositiveInfinity;
            }
            return x / y;
        }
    }
}