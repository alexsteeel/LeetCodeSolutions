using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0202Tests
    {
        [TestCase(19, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = false)]
        public bool IsHappy(int input)
        {
            var problem0202 = new Problem0202();

            var result = problem0202.IsHappy(input);

            return result;
        }
    }
}