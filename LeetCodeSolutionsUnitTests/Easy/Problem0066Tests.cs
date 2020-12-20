using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0066Tests
    {
        [TestCase(new int[] { 1, 2, 3}, ExpectedResult = new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, ExpectedResult = new int[] { 4, 3, 2, 2 })]
        [TestCase(new int[] { 9 }, ExpectedResult = new int[] { 1, 0 })]
        [TestCase(new int[] { 9, 9 }, ExpectedResult = new int[] { 1, 0, 0 })]
        [TestCase(new int[] { 0, 0 }, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, ExpectedResult = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })]
        public int[] LengthOfLastWordTestCases(int[] input)
        {
            var problem = new Problem0066();

            return problem.PlusOne(input);
        }
    }
}