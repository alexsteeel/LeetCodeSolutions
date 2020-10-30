using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem1455Tests
    {
        [TestCase("i love eating burger", "burg", ExpectedResult = 4)]
        [TestCase("this problem is an easy problem", "pro", ExpectedResult = 2)]
        [TestCase("i am tired", "you", ExpectedResult = -1)]
        [TestCase("i use triple pillow", "pill", ExpectedResult = 4)]
        [TestCase("hello from the other side", "they", ExpectedResult = -1)]
        [TestCase("hellohello hellohellohello", "ell", ExpectedResult = -1)]
        public int IsPrefixOfWordTestCases(string sentence, string searchWord)
        {
            var problem = new Problem1455();

            var result = problem.IsPrefixOfWord(sentence, searchWord);

            return result;
        }
    }
}