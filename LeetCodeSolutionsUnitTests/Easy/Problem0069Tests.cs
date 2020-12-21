using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0069Tests
    {
        [TestCase(4, ExpectedResult = 2)]
        [TestCase(8, ExpectedResult = 2)]
        public int MySqrtTestCases(int input)
        {
            var problem = new Problem0069();

            return problem.MySqrt(input);
        }
    }
}