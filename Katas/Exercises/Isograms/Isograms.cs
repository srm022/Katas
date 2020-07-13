using System.Linq;

namespace Isograms
{
    public class Isograms
    {
        public static bool IsIsogram(string phrase)
        {
            var distinctChars = phrase
                   .ToLowerInvariant()
                   .Distinct()
                   .Count();

            return distinctChars == phrase.Length;
        }
    }
}