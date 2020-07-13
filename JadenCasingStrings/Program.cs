using System;
using Katas.Utils;

namespace JadenCasingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var tweet = "aaa Bbbb ccc ddd      sads             a  fgff 2  s ";
            Kata.Run(() => tweet.ToJadenCase());
        }
    }
}
