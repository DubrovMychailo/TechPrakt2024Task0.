using System;

namespace Calulatoreasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введiть друге число:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double sum = firstNumber + secondNumber;
            Console.WriteLine($"Сума чисел {firstNumber} i {secondNumber} дорiвнює: {sum}");

            Console.ReadLine();
        }
    }
}