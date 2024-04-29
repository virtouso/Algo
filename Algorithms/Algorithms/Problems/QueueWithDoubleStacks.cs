using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class QueueWithDoubleStacks<T>
    {
        private Stack<T> inbox = new Stack<T>();
        private Stack<T> outbox = new Stack<T>();

        public void Enqueue(T item)
        {
            inbox.Push(item);
        }

        public T Dequeue()
        {
            if (outbox.Count == 0)
            {
                // If outbox is empty, transfer elements from inbox to outbox
                while (inbox.Count > 0)
                {
                    outbox.Push(inbox.Pop());
                }
            }

            if (outbox.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return outbox.Pop();
        }

        public T Peek()
        {
            if (outbox.Count == 0)
            {
                // If outbox is empty, transfer elements from inbox to outbox
                while (inbox.Count > 0)
                {
                    outbox.Push(inbox.Pop());
                }
            }

            if (outbox.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return outbox.Peek();
        }

        public int Count
        {
            get { return inbox.Count + outbox.Count; }
        }

        public bool IsEmpty
        {
            get { return Count == 0; }
        }
    }
}