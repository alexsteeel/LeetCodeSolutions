using LeetCodeSolutions;
using NUnit.Framework;

namespace LeetCodeSolutionsUnitTests
{
    public class Problem0021Tests
    {
        [Test]
        public void MergeTwoListsTests()
        {
            var problem = new Problem0021();
            var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var result = problem.MergeTwoLists(l1, l2);

            Assert.AreEqual(3, result.next.next.next.val);
        }

        [Test]
        public void MergeTwoLists_Empty()
        {
            var problem = new Problem0021();
            var l1 = new ListNode();
            ListNode l2 = null;

            var result = problem.MergeTwoLists(l1, l2);

            Assert.AreEqual(l1, result);
        }

        [Test]
        public void MergeTwoLists_TwoOneElementLists_SortResult()
        {
            var problem = new Problem0021();
            var l1 = new ListNode(2);
            var l2 = new ListNode(1);

            var result = problem.MergeTwoLists(l1, l2);

            Assert.AreEqual(2, result.next.val);
        }
    }
}