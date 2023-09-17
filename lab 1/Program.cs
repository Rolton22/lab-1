using System;

namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double number1 = random.NextDouble() * 100 - 50, number2 = random.NextDouble() * 100 - 50;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, Sum(number1, number2));
        }

        /// <summary>
        /// функция вычисления суммы двух вещественных чисел
        /// </summary>
        /// <param name="number1">прибавляемое</param>
        /// <param name="number2">прибавляющее</param>
        /// <returns>частное</returns>

        static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}