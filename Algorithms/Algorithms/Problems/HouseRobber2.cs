using System;

namespace Algorithms.Problems
{
    public class HouseRobber2
    {
        // house robber but first house and last house in list are connected
        
        public int Rob(int[] nums) {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
        
            // Maximum amount if we rob the first house
            int max1 = RobHelper(nums, 0, nums.Length - 2);
            // Maximum amount if we don't rob the first house
            int max2 = RobHelper(nums, 1, nums.Length - 1);
        
            return Math.Max(max1, max2);
        }
    
        private int RobHelper(int[] nums, int start, int end) {
            int prevMax = 0;
            int currMax = 0;
        
            for (int i = start; i <= end; i++) {
                int temp = currMax;
                currMax = Math.Max(prevMax + nums[i], currMax);
                prevMax = temp;
            }
        
            return currMax;
        }
    }
}