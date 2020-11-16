using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0028Tests
    {
        [TestCase("hello", "ll", ExpectedResult = 2)]
        [TestCase("aaa", "aaaa", ExpectedResult = -1)]
        [TestCase("mississippi", "mississippi", ExpectedResult = 0)]
        [TestCase("aaaaa", "bba", ExpectedResult = -1)]
        [TestCase("", "", ExpectedResult = 0)]
        public int StrStrTestCases(string haystack, string needle)
        {
            var problem = new Problem0028();

            return problem.StrStr(haystack, needle);
        }
    }
}