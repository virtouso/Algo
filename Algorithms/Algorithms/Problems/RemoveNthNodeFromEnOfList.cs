namespace Algorithms.Problems
{
    public class RemoveNthNodeFromEnOfList
    {
        
        
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            // Create a dummy node to handle edge cases
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode slow = dummy;
            ListNode fast = dummy;

            // Move the fast pointer n+1 steps ahead
            for (int i = 0; i <= n; i++)
            {
                if (fast == null)
                    return null; // The list does not contain n nodes
                fast = fast.next;
            }

            // Move both pointers until fast reaches the end
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            // Remove the nth node from the end
            slow.next = slow.next.next;

            return dummy.next;
        }
    }
}