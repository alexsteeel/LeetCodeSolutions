using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem1Tests
    {
        [Test]
        public void TwoSum_FourInputElements_CorrectResult()
        {
            var problem1 = new Problem1();
            var input = new int[] { 2, 7, 11, 15 };
            var expected = new int[] { 0, 1 };

            var result = problem1.TwoSum(input, 9);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TwoSum_ThreeInputElements_CorrectResult()
        {
            var problem1 = new Problem1();
            var input = new int[] { 3, 2, 4 };
            var expected = new int[] { 1, 2 };

            var result = problem1.TwoSum(input, 6);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TwoSum_TwoInputElements_CorrectResult()
        {
            var problem1 = new Problem1();
            var input = new int[] { 3, 3 };
            var expected = new int[] { 0, 1 };

            var result = problem1.TwoSum(input, 6);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TwoSum_TwoIdenticalConsecutiveElements_CorrectResult()
        {
            var problem1 = new Problem1();
            var input = new int[] { 2, 5, 5, 11 };
            var expected = new int[] { 1, 2 };

            var result = problem1.TwoSum(input, 10);

            Assert.AreEqual(expected, result);
        }
    }
}