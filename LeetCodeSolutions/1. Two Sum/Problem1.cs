namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class Problem1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new System.Exception("Solution not exists.");
        }
    }
}
