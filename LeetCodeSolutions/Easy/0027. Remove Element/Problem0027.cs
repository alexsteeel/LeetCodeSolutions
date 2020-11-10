using System.Linq;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public class Problem0027
    {
        public int RemoveElement(int[] nums, int val)
        {
            var exceptValNums = nums.Where(x => x != val).ToList();
            var count = exceptValNums.Count();
            for (int i = 0; i < count; i++)
            {
                nums[i] = exceptValNums[i];
            }
            return count;
        }
    }
}