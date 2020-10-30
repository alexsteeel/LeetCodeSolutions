using System;
using System.Linq;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    public class Problem0007
    {
        public int Reverse(int x)
        {
            var str = x.ToString().Replace("-", "");
            var res = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                res += str[i];
            };

            var isInt = int.TryParse(res, out int intRes);
            if (!isInt)
            {
                return 0;
            }

            return x > 0 ? intRes : -intRes;
        }
    }
}
