using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem1624Tests
    {
        [TestCase("aa", ExpectedResult = 0)]
        [TestCase("abca", ExpectedResult = 2)]
        [TestCase("cbzxy", ExpectedResult = -1)]
        [TestCase("cabbac", ExpectedResult = 4)]
        [TestCase("trtrtrtrtrrrrtt", ExpectedResult = 13)]
        [TestCase("q", ExpectedResult = -1)]
        [TestCase("mgntdygtxrvxjnwksqhxuxtrv", ExpectedResult = 18)]
        public int MaxLengthBetweenEqualCharactersTest(string input)
        {
            var problem1624 = new Problem1624();

            var result = problem1624.MaxLengthBetweenEqualCharacters(input);

            return result;
        }
    }
}