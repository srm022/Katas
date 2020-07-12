using System;
using System.Diagnostics;

namespace BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            sw.Start();
            Console.WriteLine(BouncingBall(100000000000, 0.66, 1.5));
            sw.Stop();
            Console.WriteLine($"Executed for: {sw.ElapsedMilliseconds}");
        }

        static int BouncingBall(double h, double bounce, double window)
        {
            if (IsRequestInvalid(h, bounce, window))
            {
                return -1;
            }

            var result = 0;
            var bounceValue = h;

            while (bounceValue >= window)
            {
                result++;
                bounceValue *= bounce;

                if (bounceValue >= window)
                {
                    result++;
                }
            }

            return result;
        }

        private static bool IsRequestInvalid(double h, double bounce, double window)
        {
            return h <= 0 &&
                   bounce <= 0 &&
                   bounce >= 1 &&
                   window >= h;

        }
    }
}
