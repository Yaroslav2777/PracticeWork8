using System;
using System.Text;

namespace Task2
{
    public delegate void ColorInfo();

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть номер кольору спектру (1-7):");
            Console.WriteLine("1 - Червоний, 2 - Помаранчевий, 3 - Жовтий, 4 - Зелений,");
            Console.WriteLine("5 - Блакитний, 6 - Синій, 7 - Фіолетовий");

            Console.Write("\nВаш вибір: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                ColorInfo[] spectrum = new ColorInfo[]
                {
                    Red,
                    Orange,
                    Yellow,
                    Green,
                    LightBlue,
                    Blue,
                    Violet
                };
                if (choice >= 1 && choice <= 7)
                {
                    spectrum[choice - 1]();
                }
                else
                {
                    Console.WriteLine("Помилка: введіть число від 1 до 7.");
                }
            }
            else
            {
                Console.WriteLine("Потрібно було ввести ціле число.");
            }
        }
        static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Колір: Червоний | RGB: (255, 0, 0)");
            Console.ResetColor();
        }

        static void Orange()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Колір: Помаранчевий | RGB: (255, 165, 0)");
            Console.ResetColor();
        }

        static void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Колір: Жовтий | RGB: (255, 255, 0)");
            Console.ResetColor();
        }

        static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Колір: Зелений | RGB: (0, 128, 0)");
            Console.ResetColor();
        }

        static void LightBlue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Колір: Блакитний | RGB: (0, 191, 255)");
            Console.ResetColor();
        }

        static void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Колір: Синій | RGB: (0, 0, 255)");
            Console.ResetColor();
        }

        static void Violet()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Колір: Фіолетовий | RGB: (139, 0, 255)");
            Console.ResetColor();
        }
    }
}