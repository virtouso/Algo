namespace Algorithms.Problems
{
    public class FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            var result = nums[0];


            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1]) return nums[i];
            }

            return result;
        }
    }
}