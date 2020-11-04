using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0014Tests
    {
        [Test]
        public void LongestCommonPrefix_HasCommonPrefix_ReturnPrefix()
        {
            var problem = new Problem0014();
            var strs = new string[] { "flower", "flow", "flight" };

            var result = problem.LongestCommonPrefix(strs);

            Assert.AreEqual("fl", result);
        }

        [Test]
        public void LongestCommonPrefix_NoCommonPrefix_ReturnEmptyString()
        {
            var problem = new Problem0014();
            var strs = new string[] { "dog", "racecar", "car" };

            var result = problem.LongestCommonPrefix(strs);

            Assert.AreEqual("", result);
        }

        [Test]
        public void LongestCommonPrefix_EmptyArray_ReturnEmptyString()
        {
            var problem = new Problem0014();
            var strs = new string[] { };

            var result = problem.LongestCommonPrefix(strs);

            Assert.AreEqual("", result);
        }

        [Test]
        public void LongestCommonPrefix_OneElement_ReturnElement()
        {
            var problem = new Problem0014();
            var strs = new string[] { "asd" };

            var result = problem.LongestCommonPrefix(strs);

            Assert.AreEqual("asd", result);
        }

        [Test]
        public void LongestCommonPrefix_FirstElemIsLongerThanOthers_ReturnPrefix()
        {
            var problem = new Problem0014();
            var strs = new string[] { "ab", "a" };

            var result = problem.LongestCommonPrefix(strs);

            Assert.AreEqual("a", result);
        }
    }
}