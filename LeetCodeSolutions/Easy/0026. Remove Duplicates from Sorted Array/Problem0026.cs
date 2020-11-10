using System.Linq;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class Problem0026
    {
        public int RemoveDuplicates(int[] nums)
        {
            var distinctNums = nums.Distinct().ToArray();
            var count = distinctNums.Count();
            for (int i = 0; i < count; i++)
            {
                nums[i] = distinctNums[i];
            }

            return count;
        }
    }
}