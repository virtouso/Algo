namespace Algorithms.Problems
{
    public class ReorderListProblem
    {

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }

        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null) return;

            // Step 1: Find the middle of the list
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Step 2: Reverse the second half of the list
            ListNode prev = null, curr = slow, next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            // Step 3: Merge the two halves
            ListNode first = head, second = prev;
            while (second.next != null)
            {
                ListNode tmp1 = first.next;
                ListNode tmp2 = second.next;

                first.next = second;
                second.next = tmp1;

                first = tmp1;
                second = tmp2;
            }
        }
    }
}