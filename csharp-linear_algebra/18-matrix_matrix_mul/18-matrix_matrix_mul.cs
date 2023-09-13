using System;

/// <summary>
/// class for performing Matrix operations
/// </summary>
class MatrixMath {

    /// <summary>
    /// method that multiplies two matrices and returns the resulting matrix
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null || matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] {{-1}};
        
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                for (int k = 0; k < matrix1.GetLength(1); k++)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
        
        return result;
    }
}