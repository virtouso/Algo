﻿namespace Algorithms.Problems
{
    public class LinkedListCycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }


        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while (fast != null && fast.next != null) {
                if (slow == fast)
                    return true;

                slow = slow.next;
                fast = fast.next.next;
            }

            return false;
            
        }

    }
}