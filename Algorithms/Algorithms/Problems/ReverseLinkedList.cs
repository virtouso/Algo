namespace Algorithms.Problems
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            ListNode next = null;
            while (current != null) {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;

            return head;
        }
        
        
        public void AddNode(int data) {
            ListNode newNode = new ListNode(data);
            if (Head == null) {
                Head = newNode;
                return;
            }
            ListNode lastNode = Head;
            while (lastNode.Next != null) {
                lastNode = lastNode.Next;
            }
            lastNode.Next = newNode;
        }

        private ListNode Head;

        public class ListNode
        {
            public int val;
            public ListNode Next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.Next = next;
            }
        }
    }
}