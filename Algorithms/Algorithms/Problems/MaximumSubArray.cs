using System;

namespace Algorithms.Problems
{
    public class MaximumSubArray
    {
        public int MaxSubArray(int[] nums) {
            int max = nums[0];
            int current = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (current < 0)
                    current = 0;
                current += nums[i];
                max = Math.Max(current, max);
            }

            return max;
        }
    }
}