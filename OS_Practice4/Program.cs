using System;

namespace OS_Practice4
{
    internal static class Program
    {
        private static int Enter(string message)
        {
            while (true)
            {
                Console.WriteLine($"Введите {message}");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int _))
                {
                    return Convert.ToInt32(input);
                }
            }
        }

        private static int F(int arg, int b, int c)
        {
            if (arg == 0) return 0;

            int a = 0;
            for (int i = 1; i < 100000000; i++)
            {
                a += 2 * b + c - arg;
            }

            return F(arg - 1, b, c) + a;
        }

        private static void Main()
        {
            int arg = Enter("Введите i");
            int b = Enter("Введите b");
            int c = Enter("Введите c");
            Console.WriteLine("Считаем...");
            DateTime start = DateTime.Now;
            int result = F(arg, b, c);
            Console.WriteLine($"Время: {DateTime.Now - start}");
            Console.WriteLine($"Ответ: {result}");
        }
    }
}
