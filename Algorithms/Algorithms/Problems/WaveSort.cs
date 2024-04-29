using System;

namespace Algorithms.Problems
{
    public class WaveSort
    {
        public  void WaveSortArray(int[] arr)
        {
            Array.Sort(arr); // Sort the array first

            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                // Swap adjacent elements to create the wave pattern
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
    }
}