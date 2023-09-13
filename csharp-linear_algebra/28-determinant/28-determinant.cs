using System;

/// <summary>
/// class for performing Matrix operations
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that calculates the determinant of a matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static double Determinant(double[,] matrix)
    {
        double a = 0;
        double b = 0;
        if (matrix == null
            || matrix.GetLength(0) != matrix.GetLength(1)
            || matrix.GetLength(0) < 2
            || matrix.GetLength(0) > 3)
            return -1;
        
        if (matrix.GetLength(0) == 2)
        {
            a = matrix[0, 0] * matrix[1, 1];
            b = matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            a = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[0, 2] * matrix[1, 0] * matrix[2, 1];
            b = matrix[0, 2] * matrix[1, 1] * matrix[2, 0] + matrix[0, 1] * matrix[1, 0] * matrix[2, 2] + matrix[0, 0] * matrix[1, 2] * matrix[2, 1];
        }
        return a - b;
    }

}