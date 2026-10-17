using System;

namespace HomeworkFive
{
    class Program
    {
        public static long Factor(long mainNumber)
        {
            if (mainNumber == 0 || mainNumber == 1) return 1;
            return checked(mainNumber * Factor(mainNumber - 1));
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            long m = int.Parse(Console.ReadLine() ?? "");
            if (m < 0) Console.WriteLine("Поиск факториала невозможен");
            else Console.WriteLine(Factor(m));
        }
    }
}