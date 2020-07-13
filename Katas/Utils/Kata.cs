using System;

namespace Utils
{
    public static class Kata
    {
        public static void Run<T>(Func<T> action)
        {
            var result = action();

            Console.WriteLine($"Execution finished, result is:\n\n" +
                              $"{result}" +
                              $"\n\n=============================\n" +
                              $"Press any key to exit.");
            Console.ReadKey();
        }
    }
}