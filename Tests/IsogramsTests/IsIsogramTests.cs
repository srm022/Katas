using NUnit.Framework;

namespace IsogramsTests
{
    public class IsIsogramTests
    {
        [TestCase("subdermatoglyphic")]
        [TestCase("abcdef")]
        [TestCase("ABCDEF")]
        [TestCase("abcDEF")]
        [TestCase("ABCdef")]
        [TestCase("A BCDeF")]
        [TestCase("ABCDeF ")]
        [TestCase(" ABCDeF")]
        [TestCase("ABC123DEF")]
        [TestCase("ABC123def")]
        [TestCase("1234567")]
        [TestCase("!@#$%^")]
        [TestCase("abc123!@#")]
        [TestCase("A ;B2%c'x/z")]
        [TestCase("123\n456")]
        public void Should_Pass_For_Correct_Value(string phrase)
        {
            Assert.True(Isograms.Isograms.IsIsogram(phrase));
        }

        [TestCase("abccdef")]
        [TestCase("ABCCDEF")]
        [TestCase("abcDDEF")]
        [TestCase("pasS")]
        [TestCase("A  BCDeF")]
        [TestCase("ABCDeF  ")]
        [TestCase("  ABCDeF")]
        [TestCase("ABC1123")]
        [TestCase("ABC1233def")]
        [TestCase("!!@#")]
        [TestCase("A ;B2%c'x//z")]
        [TestCase("123\n\n456")]
        public void Should_Pass_For_Incorrect_Value(string phrase)
        {
            Assert.False(Isograms.Isograms.IsIsogram(phrase));
        }
    }
}