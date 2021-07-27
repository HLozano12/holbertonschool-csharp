using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Text
{
    /// <summary>String class</summary>
    public class Str
    {
        /// <summary>Method to verify if string is palindrome</summary>
        public static bool IsPalindrome(string s)
        {
            var letters = new StringBuilder();
            s = s.ToLower();
            char[] str = s.ToCharArray();
            for (int h = 0; h < str.Length; h++)
            {
                if (str[h] >= 'a' && str[h] <= 'z')
                {
                    letters.Append(str[h]);
                }
            }
            int j = letters.Length - 1;
            /// <summary> s is not palindrome </summary>
            for (int i = 0; i <= j; i++, j--)
            {
                if (letters[i] != letters[j])
                    return false;
            }
            /// <summary> s is palindrome </summary>
            return true;
        }
    }
}	