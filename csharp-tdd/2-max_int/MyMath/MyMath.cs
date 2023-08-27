using System;

namespace MyMath
{
	/// <summary>
	/// Contains operations for performing math on objects
	/// </summary>
    public class Operations
    {
		/// <summary>
		/// Returns the max integer in a list of integers
		/// </summary>
		public static int Max(List<int> nums)
		{
			if (nums.IsNullOrEmpty())
				return 0;
			return nums.Max();
		}
    }
}
