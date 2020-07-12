using System;
using System.Linq;

namespace JadenCasingStrings
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            var words = phrase
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            return string.Join(" ", words.Select(Capitalize));
        }

        private static string Capitalize(this string word) => char.ToUpper(word[0]) + word[1..];
    }
}