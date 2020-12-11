using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0053Tests
    {
        [TestCase(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, ExpectedResult = 6)]
        [TestCase(new int[] { 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { -1 }, ExpectedResult = -1)]
        [TestCase(new int[] { -2147483647 }, ExpectedResult = -2147483647)]
        [TestCase(new int[] { -2, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { -2, -1 }, ExpectedResult = -1)]
        [TestCase(new int[] { 1, 2 }, ExpectedResult = 3)]
        public int MaxSubArray(int[] input)
        {
            var problem = new Problem0053();

            return problem.MaxSubArray(input);
        }
    }
}