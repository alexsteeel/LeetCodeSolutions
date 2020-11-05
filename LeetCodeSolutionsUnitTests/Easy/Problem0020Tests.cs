using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0020Tests
    {
        [TestCase("()", ExpectedResult = true)]
        [TestCase("()[]{}", ExpectedResult = true)]
        [TestCase("(]", ExpectedResult = false)]
        [TestCase("([)]", ExpectedResult = false)]
        [TestCase("{[]}", ExpectedResult = true)]
        [TestCase("[", ExpectedResult = false)]
        [TestCase("]", ExpectedResult = false)]
        public bool IsValidTests(string input)
        {
            var problem = new Problem0020();

            var result = problem.IsValid(input);

            return result;
        }
    }
}