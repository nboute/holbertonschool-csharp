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
		/// Tells if a string is a palindrome
		/// </summary>
		public static bool IsPalindrome(string s)
		{
			if (s.Length == 0 || s.Length == 1)
				return true;
			s = new string(s.Where(c => !char.IsPunctuation(c)).ToArray());

			for (int i = 0; i < s.Length / 2; i++)
			{
				if (char.ToLower(s[i]) != char.ToLower(s[s.Length - 1 - i]))
				{
					return false;
				}
			}
			return true;
		}
    }
}
