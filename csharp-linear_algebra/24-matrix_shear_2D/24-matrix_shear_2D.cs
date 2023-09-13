using System;

/// <summary>
/// class for performing Matrix operations
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that shears a square 2D matrix by a given shear factor and returns the resulting matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="direction"></param>
    /// <param name="factor"></param>
    /// <returns></returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] result, shearMatrix;

        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};
        
        result = new double[2, 2];
        shearMatrix = new double[,] { { 1, 0 }, { 0, 1 } };
        if (direction == 'x')
            shearMatrix[0, 1] = factor;
        else if (direction == 'y')
            shearMatrix[1, 0] = factor;
        else
            return new double[,] {{-1}};
        
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    result[i, j] += matrix[i, k] * shearMatrix[k, j];

        return result;
    }

}