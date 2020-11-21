using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0035Tests
    {
        [TestCase(new int[] { 1, 3, 5, 6 }, 5, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 2, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 7, ExpectedResult = 4)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 0, ExpectedResult = 0)]
        [TestCase(new int[] { 1 }, 0, ExpectedResult = 0)]
        public int SearchInsertTestCases(int[] nums, int target)
        {
            var problem = new Problem0035();

            return problem.SearchInsert(nums, target);
        }
    }
}