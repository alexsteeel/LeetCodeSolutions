using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0009Tests
    {
        [TestCase(121, ExpectedResult = true)]
        [TestCase(-121, ExpectedResult = false)]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(-101, ExpectedResult = false)]
        public bool IsPalindromeTests(int input)
        {
            var problem = new Problem0009();

            var result = problem.IsPalindrome(input);

            return result;
        }
    }
}