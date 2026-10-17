using System;

namespace HomeworkFive
{
    class Program
    {
        public static long Factor(long mainNumber)
        {
            if (mainNumber == 2) return 2;
            return checked(mainNumber * Factor(mainNumber - 1));
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            long m = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine(Factor(m));
        }
    }
}