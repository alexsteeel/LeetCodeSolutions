using System.Collections.Generic;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class Problem0014
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result = "";

            if (strs.Length == 0)
            {
                return result;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            for (int i = 0; i < strs[0].Length; i++)
            {
                char ch = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length <= i)
                    {
                        return result;
                    }

                    if (strs[j][i] != ch)
                    {
                        return result;
                    }
                }
                result += ch;
            }

            return result;
        }
    }
}