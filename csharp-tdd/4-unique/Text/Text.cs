using System;
using System.Linq;

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
			if (s.Length == 1)
				return 0;
			try
			{
				return s.IndexOf(s.GroupBy(c => c).First(ls => ls.Count() == 1).Key);
			} catch (InvalidOperationException) {
				return -1;
			}
		}
    }
}
