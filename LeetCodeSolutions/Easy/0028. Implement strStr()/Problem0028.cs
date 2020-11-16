using System.ComponentModel.DataAnnotations;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/implement-strstr/
    /// </summary>
    public class Problem0028
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length == 0
                && needle.Length == 0)
            {
                return 0;
            }

            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j <= needle.Length; j++)
                {
                    if (j == needle.Length)
                    {
                        return i;
                    }

                    if (i + j >= haystack.Length)
                    {
                        return -1;
                    }

                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }
            }

            return -1;
        }
    }
}
