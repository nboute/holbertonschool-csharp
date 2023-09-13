using System.Text.RegularExpressions;
using System;

/// <summary>
/// Class for performing Vector operations
/// </summary>
class VectorMath
{
    /// <summary>
    /// /// The Magnitude function returns the magnitude of a vector,
    /// which is the square root of the sum of the squares of the vector's components.
    /// For example, the magnitude of the vector (1, 2, 3) 
    /// is sqrt(1^2 + 2^2 + 3^2) = sqrt(14) = 3.74.
    /// </summary>
    /// <param name="vector"></param>
    /// <returns></returns>
    public static double Magnitude(double[] vector)
    {
        // Check if vector is null or if it's not 2D or 3D
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return -1;
        double square_diag = 0;
        foreach (double value in vector)
        {
            square_diag += value * value;
        }
        
        return Math.Round(Math.Sqrt(square_diag), 2);
    }
}