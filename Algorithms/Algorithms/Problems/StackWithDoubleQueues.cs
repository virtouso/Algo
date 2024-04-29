using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class StackWithDoubleQueues<T>
    {
        private Queue<T> mainQueue = new Queue<T>();
        private Queue<T> tempQueue = new Queue<T>();

        public void Push(T item)
        {
            // Add the new item to the mainQueue
            mainQueue.Enqueue(item);
        }

        public T Pop()
        {
            if (mainQueue.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            // Move all elements except the last one from mainQueue to tempQueue
            while (mainQueue.Count > 1)
            {
                tempQueue.Enqueue(mainQueue.Dequeue());
            }

            // Retrieve and return the last element from mainQueue
            T poppedItem = mainQueue.Dequeue();

            // Swap the mainQueue and tempQueue references
            SwapQueues();

            return poppedItem;
        }

        public T Peek()
        {
            if (mainQueue.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            // Move all elements except the last one from mainQueue to tempQueue
            while (mainQueue.Count > 1)
            {
                tempQueue.Enqueue(mainQueue.Dequeue());
            }

            // Retrieve the last element from mainQueue
            T peekedItem = mainQueue.Peek();

            // Move the last element back to mainQueue
            tempQueue.Enqueue(mainQueue.Dequeue());

            // Swap the mainQueue and tempQueue references
            SwapQueues();

            return peekedItem;
        }

        public int Count
        {
            get { return mainQueue.Count; }
        }

        public bool IsEmpty
        {
            get { return mainQueue.Count == 0; }
        }

        private void SwapQueues()
        {
            // Swap mainQueue and tempQueue references
            Queue<T> temp = mainQueue;
            mainQueue = tempQueue;
            tempQueue = temp;
        }
    }
}