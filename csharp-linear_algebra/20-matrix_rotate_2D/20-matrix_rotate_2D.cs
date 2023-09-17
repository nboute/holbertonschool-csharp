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
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        double[,] result = new double[2, 2];

        result[0, 0] = Math.Round(matrix[0, 0] * cosAngle - matrix[0, 1] * sinAngle, 2);
        result[0, 1] = Math.Round(matrix[0, 0] * sinAngle + matrix[0, 1] * cosAngle, 2);
        result[1, 0] = Math.Round(matrix[1, 0] * cosAngle - matrix[1, 1] * sinAngle, 2);
        result[1, 1] = Math.Round(matrix[1, 0] * sinAngle + matrix[1, 1] * cosAngle, 2);

        return result;
    }
}
