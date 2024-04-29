using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class SortStack
    {
        public  void Sort(Stack<int> stack)
        {
            Stack<int> tempStack = new Stack<int>();

            while (stack.Count > 0)
            {
                int temp = stack.Pop();

                // Move elements from tempStack back to stack until tempStack is empty or top of tempStack is greater than temp
                while (tempStack.Count > 0 && tempStack.Peek() > temp)
                {
                    stack.Push(tempStack.Pop());
                }

                // Push temp onto tempStack
                tempStack.Push(temp);
            }

            // Move elements from tempStack back to stack
            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
        }

    }
}