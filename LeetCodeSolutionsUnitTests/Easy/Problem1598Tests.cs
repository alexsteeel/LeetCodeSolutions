using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem1598Tests
    {
        [TestCase(arg:new string[] { "d1/", "d2/", "../", "d21/", "./" }, ExpectedResult = 2)]
        [TestCase(arg: new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }, ExpectedResult = 3)]
        [TestCase(arg: new string[] { "d1/", "../", "../", "../" }, ExpectedResult = 0)]
        public int MinOperationsTestCases(string[] input)
        {
            var problem = new Problem1598();

            var result = problem.MinOperations(input);

            return result;
        }
    }
}