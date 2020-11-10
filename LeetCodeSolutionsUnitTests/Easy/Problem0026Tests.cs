using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0026Tests
    {
        [Test]
        public void RemoveDuplicates_Return2()
        {
            var list = new int[] { 1, 1, 2 };
            var problem = new Problem0026();

            var result = problem.RemoveDuplicates(list);

            Assert.AreEqual(new int[] { 1, 2, 2 }, list);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void RemoveDuplicates_Return5()
        {
            var list = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var problem = new Problem0026();

            var result = problem.RemoveDuplicates(list);

            Assert.AreEqual(5, result);
        }
    }
}