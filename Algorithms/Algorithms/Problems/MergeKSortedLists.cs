using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class MergeKSortedLists
    {

        public class ListNode
        {
            public ListNode(int val )
            {
                Val = val;
            }
            public int Val { get; set; }
            public ListNode next { get; set; }
        }
        
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            return MergeKLists(lists, 0, lists.Length - 1);
        }

        private ListNode MergeKLists(ListNode[] lists, int left, int right)
        {
            if (left == right) return lists[left];

            int mid = left + (right - left) / 2;
            ListNode l1 = MergeKLists(lists, left, mid);
            ListNode l2 = MergeKLists(lists, mid + 1, right);
            return MergeTwoLists(l1, l2);
        }

        private ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.Val < l2.Val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            if (l1 != null) current.next = l1;
            if (l2 != null) current.next = l2;

            return dummy.next;
        }
    }
}