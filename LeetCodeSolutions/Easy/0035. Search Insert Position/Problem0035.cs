using System.Net.WebSockets;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position/
    /// </summary>
    public class Problem0035
    {
        public int SearchInsert(int[] nums, int target)
        {
            var res = 0;
            var isFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                res = i;
                if (nums[i] >= target)
                {
                    isFound = true;
                    break;
                }
            }
            return isFound ? res : res + 1;
        }
    }
}
