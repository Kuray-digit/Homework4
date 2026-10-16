using System;

namespace HomeworkFive
{
    class Program
    {
        public static void Change(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленные значения");
            int a = int.Parse(Console.ReadLine() ?? "");
            int b = int.Parse(Console.ReadLine() ?? "");
            Change(ref a, ref b);
            Console.WriteLine($"{a}, {b}");
        }
    }
}