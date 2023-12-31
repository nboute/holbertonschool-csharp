﻿using System;

/// <summary>
/// Class for vector operations
/// </summary>
class VectorMath{

    /// <summary>
    /// Method that calculates dot product of either two 2D or two 3D vectors.
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1 == null
            || vector2 == null
            || vector1.Length != vector2.Length
            || vector1.Length < 2
            || vector1.Length > 3)
            return -1;
        double result = 0;
        for (int i = 0; i < vector1.Length; i++)
            result += vector1[i] * vector2[i];
        return result;
    }
}