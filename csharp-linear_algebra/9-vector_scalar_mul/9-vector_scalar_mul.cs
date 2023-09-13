using System;

/// <summary>
/// Class for vector operations
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that multiplies a vector and a scalar.
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns>returns the resulting vector.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return new double[] {-1};
        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
            result[i] = vector[i] * scalar;
        return result;
    }
}