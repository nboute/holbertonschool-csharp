using NUnit.Framework;

namespace MyMath.Tests
{
	/// <summary>
	/// Tests for 2-max_int
	/// </summary>
	[TestFixture]
    public class Tests
    {

		/// <summary>
		/// Basic test: With simple values
		/// </summary>
        [Test]
        public void Test()
        {
			List<int> nums = new List<int> { 1, 2, 3, 4, 5 };

			Assert.That(Operations.Max(nums), Is.EqualTo(5));
        }

		/// <summary>
		/// Test: With negative values
		/// </summary>
		[Test]
		public void TestNegative()
		{
			List<int> nums = new List<int> { -1, -2, -3, -4, -5 };

			Assert.That(Operations.Max(nums), Is.EqualTo(-1));
		}

		/// <summary>
		/// Test: With empty list
		/// </summary>
		[Test]
		public void TestEmpty()
		{
			List<int> nums = new List<int> { };
			Assert.That(Operations.Max(nums), Is.EqualTo(0));
		}
    }
}
