using System;

namespace Text
{
	/// <summary>
	/// Contains operations to perform on strings
	/// </summary>
    public class Str
    {
		/// <summary>
		/// Returns the index of the first non-repeating character
		/// </summary>
		public static int UniqueChar(string s)
		{
			int[] chars = new int[128];
			int i = 0;

			for (i = 0; i < s.Length; i++)
			{
				chars[s[i]]++;
				if (chars[s[i]] == 1)
					return i;
			}
			return -1;
		}
    }
}
