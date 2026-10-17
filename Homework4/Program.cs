using System;

namespace HomeworkFive
{
    class Program
    {
        static bool TryFactorial(int n, out long result)
        {
            result = 1;
            if (n < 0)
                return false;

            try
            {
                checked
                {
                    for (int i = 2; i <= n; i++)
                    {
                        result *= i;
                    }
                }
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }

            return true;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine() ?? "");
            if (n < 0) Console.WriteLine("Число меньше возможного");
            else
            {
                if (TryFactorial(n, out long fact))
                    Console.WriteLine($"{n}! = {fact}");
                else
                    Console.WriteLine($"{n}! — переполнение (результат не помещается в long)");
            }
        }
    }
}