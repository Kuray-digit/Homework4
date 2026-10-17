using System;

namespace HomeworkFive
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = (Console.ReadLine() ?? "")
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine("\nИсходный массив:");
            PrintArray(arr);

            Console.Write("\nВведите первое число из массива: ");
            int a = int.Parse(Console.ReadLine() ?? "");

            Console.Write("Введите второе число из массива: ");
            int b = int.Parse(Console.ReadLine() ?? "");

            int indexA = Array.IndexOf(arr, a);
            int indexB = Array.IndexOf(arr, b);

            if (indexA == -1 || indexB == -1)
            {
                Console.WriteLine("\nОшибка: одно из введённых чисел отсутствует в массиве.");
                return;
            }

            int temp = arr[indexA];
            arr[indexA] = arr[indexB];
            arr[indexB] = temp;

            Console.WriteLine("\nПолучившийся массив:");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }
    }
}