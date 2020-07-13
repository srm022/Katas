using Utils;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = "a bc";
            Kata.Run(() => Isograms.IsIsogram(phrase));
        }
    }
}