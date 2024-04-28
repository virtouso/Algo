using System;

namespace Algorithms.Problems
{
    public class MaxHeap
    {
        
       private int[] heap;
    private int size;
    private int capacity;

    public MaxHeap(int capacity)
    {
        this.capacity = capacity;
        this.size = 0;
        heap = new int[capacity];
    }

    private int Parent(int i) => (i - 1) / 2;
    private int LeftChild(int i) => 2 * i + 1;
    private int RightChild(int i) => 2 * i + 2;

    public void Insert(int value)
    {
        if (size == capacity)
        {
            Console.WriteLine("Heap is full. Cannot insert more elements.");
            return;
        }

        size++;
        int currentIndex = size - 1;
        heap[currentIndex] = value;

        // Maintain heap property by swapping with parent if necessary
        while (currentIndex != 0 && heap[currentIndex] > heap[Parent(currentIndex)])
        {
            // Swap current node with its parent
            int temp = heap[currentIndex];
            heap[currentIndex] = heap[Parent(currentIndex)];
            heap[Parent(currentIndex)] = temp;

            currentIndex = Parent(currentIndex);
        }
    }

    public int ExtractMax()
    {
        if (size <= 0)
        {
            Console.WriteLine("Heap is empty.");
            return int.MinValue;
        }
        else if (size == 1)
        {
            size--;
            return heap[0];
        }

        // Store the maximum value (root of the heap)
        int max = heap[0];

        // Replace root with last element and then heapify
        heap[0] = heap[size - 1];
        size--;
        MaxHeapify(0);

        return max;
    }

    private void MaxHeapify(int i)
    {
        int left = LeftChild(i);
        int right = RightChild(i);
        int largest = i;

        // Find the largest among root, left child, and right child
        if (left < size && heap[left] > heap[largest])
            largest = left;
        if (right < size && heap[right] > heap[largest])
            largest = right;

        // If largest is not the root, swap and heapify
        if (largest != i)
        {
            int temp = heap[i];
            heap[i] = heap[largest];
            heap[largest] = temp;
            MaxHeapify(largest);
        }
    }

    public void PrintHeap()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(heap[i] + " ");
        }
        Console.WriteLine();
    }
    }
}