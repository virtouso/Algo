namespace Algorithms.Problems
{
    public class MaxDifferenceInArray
    {
        public  int MaxDifference(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                // If the array is null or has less than 2 elements, there's no difference
                return -1;
            }

            int minElement = arr[0]; // Initialize the minimum element
            int maxDifference = arr[1] - arr[0]; // Initialize the maximum difference

            for (int i = 1; i < arr.Length; i++)
            {
                // Update the maximum difference if the current element minus the minimum element is greater
                if (arr[i] - minElement > maxDifference)
                {
                    maxDifference = arr[i] - minElement;
                }

                // Update the minimum element if the current element is smaller
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }

            return maxDifference;
        }
    }
}