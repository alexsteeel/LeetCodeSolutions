namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
    /// </summary>
    public class Problem1455
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(searchWord))
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}