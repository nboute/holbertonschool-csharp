using NUnit.Framework;

namespace Text.Tests
{
	[TestFixture]
    public class Tests
    {


		/// <summary>
		/// Basic tests: With simple values
		/// </summary>
        [TestCase("racecar", true)]
		[TestCase("Laval", true)]
		[TestCase("haNnah", true)]
		[TestCase("LevEl", true)]
		[TestCase("RADAR", true)]
		[TestCase("sagas", true)]
		[TestCase("jambon", false)]
		[TestCase("radars", false)]
		[TestCase("lola", false)]

        public void TestPalindrome(string s, bool expected)
		{
			Assert.AreEqual(Str.IsPalindrome(s), expected);
		}

		/// <summary>
		/// Test: Empty string
		/// </summary>
		[Test]
		public void TestEmpty()
		{
			Assert.AreEqual(Str.IsPalindrome(""), true);
		}

		[TestCase("A man, a plan, a canal: Panama.", true)]
		[TestCase("No 'x' in Nixon", true)]
		public void TestPunctuation(string s, bool expected)
		{
			Assert.AreEqual(Str.IsPalindrome(s), expected);
		}
    }
}
