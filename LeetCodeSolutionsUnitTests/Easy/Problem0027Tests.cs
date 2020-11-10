using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0027Tests
    {
        [Test]
        public void RemoveElement_Return2()
        {
            var list = new int[] { 3, 2, 2, 3 };
            var problem = new Problem0027();

            var result = problem.RemoveElement(list, 3);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void RemoveElement_Return5()
        {
            var list = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var problem = new Problem0027();

            var result = problem.RemoveElement(list, 2);

            Assert.AreEqual(5, result);
        }
    }
}