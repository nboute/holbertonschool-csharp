using System;

/// <summary>
/// Class for performing Vector operations
/// </summary>
class VectorMath
{
    /// <summary>
    /// The Add function returns the sum of two vectors.
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Check if vector1 and vector2 are 2D or 3D and are the same size
        if (vector1 == null
            || vector2 == null 
            || (vector1.Length != 2 && vector1.Length != 3)
            || (vector1.Length != vector2.Length))
            return new double[] {-1};
        double[] sum = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            sum[i] = vector1[i] + vector2[i];
        }
        return sum;
    }
}