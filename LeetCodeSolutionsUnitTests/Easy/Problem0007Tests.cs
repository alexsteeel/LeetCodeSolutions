using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0007Tests
    {
        [TestCase(123, ExpectedResult = 321)]
        [TestCase(-123, ExpectedResult = -321)]
        [TestCase(120, ExpectedResult = 21)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-2147483648, ExpectedResult = 0)]
        public int ReverseTests(int input)
        {
            var problem = new Problem0007();

            var result = problem.Reverse(input);

            return result;
        }
    }
}