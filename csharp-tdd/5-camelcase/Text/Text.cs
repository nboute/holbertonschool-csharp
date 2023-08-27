using System;

namespace Text
{
	/// <summary>
	/// Contains operations to perform on strings
	/// </summary>
    public class Str
    {
		/// <summary>
		/// Returns the number of words in a camelcase string
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns> <summary>
		public static int CamelCase(string s)
		{
			int count = 1;

			if (s.Length == 0)
				return 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (char.IsUpper(s[i]))
					count++;
			}
			return count;
		}
    }
}
