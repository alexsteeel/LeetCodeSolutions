namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class Problem0021
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            var isFirst = true;
            ListNode result = new ListNode();
            var temp1 = l1;
            var temp2 = l2;

            while (temp1 != null && temp2 != null)
            {
                if (temp1.val == temp2.val)
                {
                    if (isFirst)
                    {
                        result = new ListNode(temp1.val, new ListNode(temp2.val));
                        isFirst = false;
                    }
                    else
                    {
                        AddNode(result, new ListNode(temp1.val, new ListNode(temp2.val)));
                    }

                    temp1 = temp1.next;
                    temp2 = temp2.next;
                }
                else if (temp1.val < temp2.val)
                {
                    if (isFirst)
                    {
                        result = new ListNode(temp1.val);
                        isFirst = false;
                    }
                    else
                    {
                        AddNode(result, new ListNode(temp1.val));
                    }
                    temp1 = temp1.next;
                }
                else if (temp2.val < temp1.val)
                {
                    if (isFirst)
                    {
                        result = new ListNode(temp2.val);
                        isFirst = false;
                    }
                    else
                    {
                        AddNode(result, new ListNode(temp2.val));
                    }
                    temp2 = temp2.next;
                }
            }

            if (temp1 != null)
            {
                AddNode(result, temp1);
            }

            if (temp2 != null)
            {
                AddNode(result, temp2);
            }

            return result;
        }

        public void AddNode(ListNode data, ListNode addNode)
        {
            if (data.next == null)
            {
                data.next = addNode;
            }
            else
            {
                var current = data.next;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = addNode;
            }
        }
    }
}