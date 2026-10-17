using System;

namespace HomeworkFive
{
    class Program
    {
        enum GrumpinessLevel
        {
            Low,
            Medium,
            High,
            Extreme
        }

        struct Grandfather
        {
            public string Name;
            public GrumpinessLevel Grumpiness;
            public string[] Phrases;
            public int Bruises; // синяки

            public Grandfather(string name, GrumpinessLevel grumpiness, params string[] phrases)
            {
                Name = name;
                Grumpiness = grumpiness;
                Phrases = phrases;
                Bruises = 0; // по умолчанию
            }
            public int GetBruisesFromGrandma(params string[] swearWords)
            {
                int count = 0;

                if (Phrases != null && swearWords != null)
                {
                    foreach (string phrase in Phrases)
                    {
                        if (phrase == null) continue;

                        foreach (string swear in swearWords)
                        {
                            if (swear == null) continue;

                            if (phrase.IndexOf(swear, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                count++;
                                break;
                            }
                        }
                    }
                }

                Bruises += count;
                return count;
            }
        }
        public static void Main(string[] args)
        {
            Grandfather[] grandfathers =
            {
            new Grandfather("Иван", GrumpinessLevel.Low,
                "Проститутки!"),

            new Grandfather("Пётр", GrumpinessLevel.Medium,
                "Гады!", "Совсем стыд потеряли!"),

            new Grandfather("Семён", GrumpinessLevel.High,
                "Проститутки!", "Гады!", "Молодёжь пошла не та!"),

            new Grandfather("Николай", GrumpinessLevel.Extreme,
                "Проститутки!", "Гады!", "Идиоты!", "Да что ж такое!",
                "Раньше было лучше!"),

            new Grandfather("Василий", GrumpinessLevel.Medium,
                "Гады!", "Дурак!", "Олухи!", "Проститутки!")
            };


            string[] swearWords = { "Проститутки", "Гады", "Дурак" };

            foreach (Grandfather g in grandfathers)
            {
                Grandfather current = g;
                int fin = current.GetBruisesFromGrandma(swearWords);

                Console.WriteLine($"Дед: {current.Name} ({current.Grumpiness})");
                Console.WriteLine($"  Фраз: {current.Phrases.Length}");
                Console.WriteLine($"  Новых фингалов: {fin}");
                Console.WriteLine($"  Всего синяков: {current.Bruises}");
                Console.WriteLine();
            }
        }
    }
}