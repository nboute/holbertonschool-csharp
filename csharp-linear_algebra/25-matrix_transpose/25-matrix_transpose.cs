using System;

/// <summary>
/// class for performing Matrix operations
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that transposes a matrix and returns the resulting matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result;

        if (matrix == null)
            return new double[,] {{}};
        
        result = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                result[j, i] = matrix[i, j];

        return result;
    }

}