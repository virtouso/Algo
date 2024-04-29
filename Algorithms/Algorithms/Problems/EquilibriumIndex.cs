namespace Algorithms.Problems
{
    public class EquilibriumIndex
    {
        public  int FindEquilibriumIndex(int[] arr)
        {
            int totalSum = 0;
            int leftSum = 0;

            // Calculate the total sum of the array
            foreach (var num in arr)
            {
                totalSum += num;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                // Subtract the current element from the total sum to get the right sum
                totalSum -= arr[i];

                if (leftSum == totalSum)
                {
                    return i; // Found equilibrium index
                }

                leftSum += arr[i]; // Add the current element to the left sum
            }

            return -1; // No equilibrium index found
        }
    }
}