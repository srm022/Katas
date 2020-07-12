using System;

namespace JadenCasingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var tweet = "aaa Bbbb ccc ddd      sads             a  fgff 2  s ";
            var jadenCased = tweet.ToJadenCase();
            Console.WriteLine(jadenCased);
            Console.ReadKey();
        }
    }
}
