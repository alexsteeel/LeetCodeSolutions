using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/largest-substring-between-two-equal-characters/
    /// </summary>
    public class Problem1624
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var max = -1;
            foreach (var ch in s)
            {
                var length = s.LastIndexOf(ch) - s.IndexOf(ch) - 1;
                if (length > max)
                {
                    max = length;
                }
            }

            return max;
        }
    }
}