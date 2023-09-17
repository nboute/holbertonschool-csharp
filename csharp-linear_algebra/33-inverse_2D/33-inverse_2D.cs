using System;

/// <summary>
/// Contains methods for matrix math.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] inverse = new double[2, 2];
        double det = 0;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (det == 0)
        {
            return new double[,] { { -1 } };
        }

        inverse[0, 0] = Math.Round(matrix[1, 1] / det, 2);
        inverse[0, 1] = Math.Round(-matrix[0, 1] / det, 2);
        inverse[1, 0] = Math.Round(-matrix[1, 0] / det, 2);
        inverse[1, 1] = Math.Round(matrix[0, 0] / det, 2);

        return inverse;
    }
}