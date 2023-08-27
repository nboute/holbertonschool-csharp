using System.Buffers;
using NUnit.Framework;

namespace MyMath.Tests
{
	/// <summary>
	/// Tests for 0-add
	/// </summary>
	[TestFixture]
    public class Tests
    {
		/// <summary>
		/// /// Basic test: Adds two integers
		/// </summary>
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-1, 2)]
        [TestCase(1000, 5)]
        [TestCase(423, 577)]
        [TestCase(-5, -5)]
        public void Test1(int a, int b)
        {
            Assert.That(Operations.Add(a, b), Is.EqualTo(a + b));
        }
	}
}
