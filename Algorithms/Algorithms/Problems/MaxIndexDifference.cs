using System;

namespace Algorithms.Problems
{
    public class MaxIndexDifference
    {
        public  int MaxIndexDiff(int[] arr)
        {
            int n = arr.Length;
            int maxDiff = -1;

            // Create two arrays to store the minimum and maximum elements from the left and right sides
            int[] leftMin = new int[n];
            int[] rightMax = new int[n];

            // Fill the leftMin array with the minimum element up to each index
            leftMin[0] = arr[0];
            for (int i = 1; i < n; i++)
            {
                leftMin[i] = Math.Min(arr[i], leftMin[i - 1]);
            }

            // Fill the rightMax array with the maximum element from each index to the end
            rightMax[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(arr[i], rightMax[i + 1]);
            }

            // Use two pointers to find the maximum difference between indices
            int ii = 0, jj = 0;
            while (ii < n && jj < n)
            {
                if (leftMin[ii] < rightMax[jj])
                {
                    maxDiff = Math.Max(maxDiff, jj - ii);
                    jj++;
                }
                else
                {
                    ii++;
                }
            }

            return maxDiff;
        }
    }
}