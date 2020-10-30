namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/crawler-log-folder/
    /// </summary>
    public class Problem1598
    {
        public int MinOperations(string[] logs)
        {
            var level = 0;

            foreach (var item in logs)
            {
                if (item.Contains("../") && level > 0)
                {
                    level--;
                }
                else if (!item.Contains("./"))
                {
                    level++;
                }
            }

            return level;
        }
    }
}