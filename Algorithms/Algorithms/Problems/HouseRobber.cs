using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class HouseRobber
    {
        public int Rob(int[] nums) {
            if (nums == null || nums.Length == 0)
                return 0;
        
            int n = nums.Length;
            if (n == 1)
                return nums[0];
        
        
            int[] dp = new int[n];
        
         
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
        
          
            for (int i = 2; i < n; i++) {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }
            
            return dp[n - 1];
        }
        
        public  int[] RobHouses(int[] nums, out int totalAmount)
        {
            if (nums == null || nums.Length == 0)
            {
                totalAmount = 0;
                return new int[0];
            }

            int n = nums.Length;
            int[] dp = new int[n];
            List<int>[] indexes = new List<int>[n];

            dp[0] = nums[0];
            indexes[0] = new List<int> { 0 };

            if (n > 1)
            {
                dp[1] = Math.Max(nums[0], nums[1]);
                indexes[1] = nums[0] > nums[1] ? new List<int> { 0 } : new List<int> { 1 };
            }

            for (int i = 2; i < n; i++)
            {
                if (nums[i] + dp[i - 2] > dp[i - 1])
                {
                    dp[i] = nums[i] + dp[i - 2];
                    indexes[i] = new List<int>(indexes[i - 2]) { i };
                }
                else
                {
                    dp[i] = dp[i - 1];
                    indexes[i] = new List<int>(indexes[i - 1]);
                }
            }

            totalAmount = dp[n - 1];
            return indexes[n - 1].ToArray();
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}