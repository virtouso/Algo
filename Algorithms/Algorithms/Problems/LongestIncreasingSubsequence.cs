using System;

namespace Algorithms.Problems
{
    public class LongestIncreasingSubsequence
    {
        
       // Input: nums = [10,9,2,5,3,7,101,18]
      //  Output: 4
      //  Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.
        
        public int LengthOfLIS(int[] nums) {
            if (nums == null || nums.Length == 0) return 0;

            int[] dp = new int[nums.Length];
            for (int i = 0; i < dp.Length; i++) {
                dp[i] = 1;
            }
            for (int i = 1; i < nums.Length; i++) {
                for (int j = 0; j < i; j++) {
                    if (nums[i] > nums[j]) {
                        dp[i] = Math.Max(dp[i], dp[j] + 1); // Update dp[i] with the maximum length of increasing subsequence ending at index i
                    }
                }
            }

            int maxLen = 0;
            foreach (int len in dp) {
                maxLen = Math.Max(maxLen, len);
            }

            return maxLen;
        }
    }
}