using NUnit.Framework;

namespace Text.Tests
{
	/// <summary>
	/// Tests for 5-camelcase
	/// </summary>
    public class Tests
    {

		/// <summary>
		/// Test with various word counts
		/// </summary>
        [TestCase("aaa", 1)]
        [TestCase("aAA", 3)]
        [TestCase("aAa", 2)]
        [TestCase("a A a", 2)]
        [TestCase("a A A ", 3)]
        public void Test1(string s, int expected)
		{
			Assert.That(Str.CamelCase(s), Is.EqualTo(expected));
		}

		/// <summary>
		/// Test with empty string
		/// </summary>
		[Test]
		public void TestEmpty()
		{
			Assert.That(Str.CamelCase(""), Is.EqualTo(0));
		}

    }
}
