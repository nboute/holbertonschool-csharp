using System;

/// <summary>
/// class for performing Matrix operations
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};

        double[,] result = new double[2, 2];
        double[,] rotation = new double[,]
            {
                { Math.Cos(angle), Math.Sin(angle) },
                { -Math.Sin(angle), Math.Cos(angle) }
            };

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                    result[i, j] += matrix[i, k] * rotation[k, j];
                result[i, j] = Math.Round(result[i, j], 2);
            }

        return result;
    }
}
