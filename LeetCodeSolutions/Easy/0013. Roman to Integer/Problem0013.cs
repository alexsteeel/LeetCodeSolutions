using System.Collections.Generic;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public class Problem0013
    {
        Dictionary<char, int> RomanNumbers = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public int RomanToInt(string s)
        {
            var result = 0;
            var prev = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var num = RomanNumbers[s[i]];
                if (num >= result || num == prev)
                {
                    result += num;
                    prev = num;
                }
                else
                {
                    result -= num;
                }
            }

            return result;
        }
    }
}
