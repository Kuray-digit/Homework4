using System;

namespace HomeworkFive
{
    class Program
    {
        public static int Factor(int mainNumber)
        {
            if (mainNumber == 2) return 2;
            return checked(mainNumber * Factor(mainNumber - 1));
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            int m = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine(Factor(m));
        }
    }
}