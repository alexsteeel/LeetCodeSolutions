using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0058Tests
    {
        [TestCase("Hello World", ExpectedResult = 5)]
        [TestCase(" ", ExpectedResult = 0)]
        [TestCase("a ", ExpectedResult = 1)]
        public int LengthOfLastWordTestCases(string input)
        {
            var problem = new Problem0058();

            return problem.LengthOfLastWord(input);
        }
    }
}