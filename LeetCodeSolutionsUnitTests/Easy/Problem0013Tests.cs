using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0013Tests
    {
        [TestCase("III", ExpectedResult = 3)]
        [TestCase("IV", ExpectedResult = 4)]
        [TestCase("IX", ExpectedResult = 9)]
        [TestCase("LVIII", ExpectedResult = 58)]
        [TestCase("MCMXCIV", ExpectedResult = 1994)]
        public int RomanToInt(string input)
        {
            var problem = new Problem0013();

            var result = problem.RomanToInt(input);

            return result;
        }
    }
}