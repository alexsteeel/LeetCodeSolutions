using System.Collections.Generic;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class Problem0020
    {
        private readonly Dictionary<char, char> _dict = new Dictionary<char, char>
        {
            {  ')', '('  },
            {  ']', '[' },
            {  '}', '{' }
        };

        public bool IsValid(string s)
        {
            var parentnesses = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (_dict.ContainsValue(s[i]))
                {
                    parentnesses.Push(s[i]);
                }
                else if (parentnesses.Count > 0
                         && parentnesses.Pop() == _dict[s[i]])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            
            return parentnesses.Count == 0;
        }
    }
}