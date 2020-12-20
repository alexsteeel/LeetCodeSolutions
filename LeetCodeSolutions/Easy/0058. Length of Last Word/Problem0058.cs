using System;
using System.Linq;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    public class Problem0058
    {
        public int LengthOfLastWord(string s)
        {
            var count = 0;
            s = s.TrimEnd();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            return count;

            //return s.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .LastOrDefault()?
            //    .Length ?? 0;
        }
    }
}
