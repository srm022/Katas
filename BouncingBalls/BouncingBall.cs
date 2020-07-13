namespace BouncingBalls
{
    public class BouncingBall
    {
        public static int GetBallPassingByWindowCount(double h, double bounce, double window)
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