using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0038Tests
    {
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(4, ExpectedResult = "1211")]
        [TestCase(5, ExpectedResult = "111221")]
        public string SearchInsertTestCases(int input)
        {
            var problem = new Problem0038();

            return problem.CountAndSay(input);
        }
    }
}