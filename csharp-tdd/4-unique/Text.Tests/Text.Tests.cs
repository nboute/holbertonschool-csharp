using NUnit.Framework;

namespace Text.Tests
{
	/// <summary>
	/// Tests for 4-unique
	/// </summary>
    public class Tests
    {

		/// <summary>
		/// Test: Repeating characters
		/// </summary>
		/// <param name="s"></param>
		/// <param name="expected"></param> <summary>
		///
		/// </summary>
		/// <param name="s"></param>
		/// <param name="expected"></param>
        [TestCase("aaa", 1)]
        [TestCase("abcdefa", 6)]
        [TestCase("abcdefab", 6)]
        public void TestRepeating(string s, int expected)
        {
            Assert.That(Str.UniqueChar(s), Is.EqualTo(expected));
        }

		/// <summary>
		/// Test: Unique characters
		/// </summary>
		/// <param name="s"></param>
		[TestCase("abc")]
        [TestCase("abcdef")]
        [TestCase("uniq")]
		[TestCase("a")]
		[TestCase("")]
		public void TestUnique(string s)
		{
			Assert.That(Str.UniqueChar(s), Is.EqualTo(-1));
		}
    }
}
