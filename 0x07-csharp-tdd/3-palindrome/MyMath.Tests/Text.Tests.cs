using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Unittests for Str method functionality.</summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>Tests Str.IsPalindrome() with a basic palindrome of lowercase letters.</summary>
        [Test]
        public void BasicPalindrome()
        {
            Assert.True(Str.IsPalindrome("level"));
        }

        /// <summary>Tests Str.IsPalindrome() with a non-palindrome of letters.</summary>
        [Test]
        public void NotPali()
        {
            Assert.False(Str.IsPalindrome("tacos"));
        }


        /// <summary>Tests Str.IsPalindrome() with an empty string.</summary>
        [Test]
        public void EmptyPali()
        {
            Assert.True(Str.IsPalindrome(""));
        }
    }
}