namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/happy-number/
    /// </summary>
    public class Problem0202
    {
        public bool IsHappy(int n)
        {
            var res = GetSumOfSquares(n);
           
            while (res > 1 && res != 4)
            {
                n = res;
                res = GetSumOfSquares(n);
            }
            return res == 1;
        }

        private int GetSumOfSquares(int n)
        {
            int res = 0;

            while (n > 0)
            {
                int d = n % 10;
                n /= 10;
                res += d * d;
            }

            return res;
        }
    }
}
