using System;

namespace MyMath
{
	/// <summary>
	/// Contains operations to perform on a matrix
	/// </summary>
    public class Matrix
    {
		/// <summary>
		/// Divides all elements of a matrix
		/// </summary>
		public static int[,] Divide(int[,] matrix, int num)
		{
			if (matrix == null)
				return null;
			try {
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					for (int j = 0; j < matrix.GetLength(1); j++)
					{
						matrix[i, j] /= num;
					}
				}
			}
			catch (DivideByZeroException) {
				Console.WriteLine("Num cannot be 0");
				return null;
			};
			return matrix;
		}
    }
}
