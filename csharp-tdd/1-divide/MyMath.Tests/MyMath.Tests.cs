using System;
using System.Runtime;
using System.Configuration.Assemblies;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Numerics;
using System.Diagnostics;
using NUnit.Framework;

namespace MyMath.Tests
{
	/// <summary>
	/// Tests for 1-divide
	/// </summary>
    public class Tests
    {
		/// Test matrix
		private int[,] matrix;

		[SetUp]
		public void Setup()
		{
			matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { -7, 8, -9 } };
		}

		[Test]
		/// <summary>
		/// Basic test: Divides matrix by 1
		/// </summary>
        public void TestDivOne()
        {
			int[,] expected = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { -7, 8, -9 } };

			int [,] result = Matrix.Divide(matrix, 1);
			Assert.That(expected, Is.EqualTo(result));
		}


		[Test]
		/// <summary>
		/// Basic test: Divides matrix by -1
		/// </summary>
        public void TestDivMinusOne()
        {
			int[,] expected = new int[,] { { -1, -2, -3 }, { -4, -5, -6 }, { 7, -8, 9 } };

			int [,] result = Matrix.Divide(matrix, -1);
			Assert.That(expected, Is.EqualTo(result));
		}

		[Test]
		/// <summary>
		/// Basic test: Divides matrix by 2
		/// </summary>
        public void TestDivTwo()
        {
			int[,] expected = new int[,] { { 0, 1, 1 }, { 2, 2, 3 }, { -3, 4, -4 } };

			int [,] result = Matrix.Divide(matrix, 2);
			Assert.That(expected, Is.EqualTo(result));
		}

		/// <summary>
		/// Test: Divide by zero
		/// </summary>
		[Test]
		public void TestDivideByZero()
		{
			Assert.DoesNotThrow(() => {
				var result = Matrix.Divide(matrix, 0);
				Assert.That(result, Is.Null);
			});
		}

		[Test]
		/// <summary>
		/// Test: Null parameter
		/// </summary>
		public void TestNullParameter()
		{
			Assert.DoesNotThrow(() => {
				var result = Matrix.Divide(null, 1);
				Assert.That(result, Is.Null);
			});
		}
    }
}
