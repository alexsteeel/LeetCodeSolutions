using System;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/sqrtx/
    /// Решение взято отсюда: http://www.codenet.ru/progr/alg/sqrt.php (4 вариант).
    /// </summary>
    public class Problem0069
    {
        public int MySqrt(int x)
        {
            var rslt = x;
            long div = x;

            if (x <= 0)
                return 0;

            while (true)
            {
                div = (x / div + div) / 2;

                if (rslt > div)
                    rslt = (int)div;
                else
                    return rslt;
            }
        }
    }
}
