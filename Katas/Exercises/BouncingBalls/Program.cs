using Utils;

namespace BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = 3.0;
            var bounce = 0.66;
            const double windowHeight = 1.5;

            Kata.Run(() => BouncingBall.GetBallPassingByWindowCount(height, bounce, windowHeight));
        }
    }
}
