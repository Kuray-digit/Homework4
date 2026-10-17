using System;

namespace HomeworkFive
{
    class Program
    {
        public static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine(Fibonachi(n));
        }
    }
}