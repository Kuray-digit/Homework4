using System;

namespace HomeworkFive
{
    class Program
    {
        public static int Maximal(int n, int m)
        {
            if (n > m)
            {
                return n;
            }
            else
            {
                return m;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите два целочисленных значения");
            int a = int.Parse(Console.ReadLine() ?? "");
            int b = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"Максимальное: {Maximal(a, b)}");
        }
    }
}