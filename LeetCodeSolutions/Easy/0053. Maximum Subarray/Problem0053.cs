using System.Linq;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// Solution is here: https://www.youtube.com/watch?v=5WZl3MMT0Eg&feature=emb_logo.
    /// </summary>
    public class Problem0053
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var max = nums[0];
            var sum = 0;

            foreach (var num in nums)
            {
                if (sum < 0)
                {
                    sum = 0;
                }
                sum += num;
                max = sum > max ? sum : max;
            }

            return max;
        }
    }
}
