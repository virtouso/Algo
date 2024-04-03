namespace Algorithms.Problems
{
    public class MissingNumber
    {
        public int CalculateMissingNumber(int[] nums)
        {
            int missing = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                missing ^= i ^ nums[i];
            }

            return missing;
        }
    }
}