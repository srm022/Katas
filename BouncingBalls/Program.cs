using System;
using System.Diagnostics;

namespace BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BouncingBall(3.0, 0.66, 1.5));
        }

        private static int BouncingBall(double h, double bounce, double window)
        {
            if (!IsRequestValid(h, bounce, window))
                return -1;

            var result = 0;
            var bounceValue = h;

            while (bounceValue > window)
            {
                result++;
                bounceValue *= bounce;

                if (bounceValue > window)
                    result++;
            }

            return result;
        }

        private static bool IsRequestValid(double h, double bounce, double window)
        {
            return h > 0 &&
                   (0 < bounce && bounce < 1) &&
                   window < h;
        }
    }
}
