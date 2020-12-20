using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/
    /// </summary>
    public class Problem0066
    {
        public int[] PlusOne(int[] digits)
        {
            digits[^1]++;
            if (digits[^1] != 10)
            {
                return digits;                
            }

            digits[^1] = 0;
            for (int i = digits.Length - 2; i >= 0; i--)
            {
                digits[i]++;
                if (digits[i] != 10)
                {
                    return digits;                    
                }
                digits[i] = 0;
            }

            var newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            return newDigits;
        }
    }
}
