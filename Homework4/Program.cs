using System;

namespace HomeworkFive
{
    class Program
    {
        public static void Main(string[] args)
        { 
            while (true)
            {
                Console.Write("Введите число (0-9) или 'exit'/'закрыть' для выхода: ");
                string input = Console.ReadLine() ?? "";
                if (input.Trim().ToLower() == "exit" || input.Trim().ToLower() == "закрыть"
                    || input.Trim() == "")
                {
                    break;
                }
                if (!int.TryParse(input, out int number))
                {
                    throw new FormatException($"Введённое значение \"{input}\" не является числом.");
                }
                if (number < 0 || number > 9)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Ошибка! Число должно быть от 0 до 9.");
                    Thread.Sleep(3000);

                    Console.ResetColor();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    DrawDigit(number);
                    Console.WriteLine();
                }
            }
        }
        
        static void DrawDigit(int digit)
        {
            string[] pattern;

            switch (digit)
            {
                case 0:
                    pattern = new[]
                    {
                    " ### ",
                    "#   #",
                    "#   #",
                    "#   #",
                    " ### "
                };
                    break;
                case 1:
                    pattern = new[]
                    {
                    "  #  ",
                    " ##  ",
                    "  #  ",
                    "  #  ",
                    " ### "
                };
                    break;
                case 2:
                    pattern = new[]
                    {
                    " ### ",
                    "#   #",
                    "   # ",
                    "  #  ",
                    "#####"
                };
                    break;
                case 3:
                    pattern = new[]
                    {
                    "#### ",
                    "    #",
                    " ### ",
                    "    #",
                    "#### "
                };
                    break;
                case 4:
                    pattern = new[]
                    {
                    "#   #",
                    "#   #",
                    "#####",
                    "    #",
                    "    #"
                };
                    break;
                case 5:
                    pattern = new[]
                    {
                    "#####",
                    "#    ",
                    "#### ",
                    "    #",
                    "#### "
                };
                    break;
                case 6:
                    pattern = new[]
                    {
                    " ### ",
                    "#    ",
                    "#### ",
                    "#   #",
                    " ### "
                };
                    break;
                case 7:
                    pattern = new[]
                    {
                    "#####",
                    "    #",
                    "   # ",
                    "  #  ",
                    "  #  "
                };
                    break;
                case 8:
                    pattern = new[]
                    {
                    " ### ",
                    "#   #",
                    " ### ",
                    "#   #",
                    " ### "
                };
                    break;
                case 9:
                    pattern = new[]
                    {
                    " ### ",
                    "#   #",
                    " ####",
                    "    #",
                    " ### "
                };
                    break;
                default:
                    return;
            }
            foreach (var line in pattern)
            {
                Console.WriteLine(line);
            }
        }
    }
}