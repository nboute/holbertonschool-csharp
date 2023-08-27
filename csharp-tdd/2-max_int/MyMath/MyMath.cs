﻿using System;
using System.Collections.Generic;
using System.Linq;

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
			if (nums == null || nums.Count == 0)
				return 0;
			return nums.Max();
		}
    }
}
