namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class Problem0009
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            if ((x >= 0 && x <= 9)
                || (x % 11 == 0 && x <= 121))
            {
                return true;
            }

            int i = 0;
            var temp = x;
            while (temp > 0)
            {
                temp /= 10;
                i++;
            }

            int y = 0;
            var temp2 = x;
            while (temp2 > 0)
            {
                var t = temp2 % 10;
                temp2 /= 10;
                var t1 = 1;
                for (int j = 1; j < i; j++)
                {
                    t1 *= 10;
                }
                y += t * t1;
                i--;
            }

            return y == x;
        }
    }
}
