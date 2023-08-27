using NUnit.Framework;
using System.Collections.Generic;

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
		/// Test: With max value at start
		/// </summary>
		[Test]
        public void TestMaxStart()
        {
			List<int> nums = new List<int> {12, 1, 2, 3, 4, 5 };

			Assert.That(Operations.Max(nums), Is.EqualTo(5));
        }

		/// <summary>
		/// Test: With max value in the middle
		/// </summary>
		[Test]
        public void TestMaxMiddle()
        {
			List<int> nums = new List<int> {12, 1, 20, 3, 4, 5 };

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
