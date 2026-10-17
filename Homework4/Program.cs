using System;

namespace HomeworkFive
{
    class Program
    {
        static double ProcessArray(ref double product, out double average, params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                product = 0;
                average = 0;
                return 0;
            }

            double sum = 0;
            product = 1;

            foreach (double n in numbers)
            {
                sum += n;
                product *= n;
            }

            average = sum / numbers.Length;
            return sum;
        }

        public static void Main(string[] args)
        {
            double product = 1; 
            double average; 
            double sum = ProcessArray(ref product, out average, 2, 4, 6, 8);

            Console.WriteLine($"Сумма:              {sum}");
            Console.WriteLine($"Произведение (ref): {product}");
            Console.WriteLine($"Среднее (out):      {average}");

            Console.WriteLine();
        }
    }
}