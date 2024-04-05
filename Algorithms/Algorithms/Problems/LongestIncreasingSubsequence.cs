using System;

namespace Algorithms.Problems
{
    public class LongestIncreasingSubsequence
    {
        
       // Input: nums = [10,9,2,5,3,7,101,18]
      //  Output: 4
      //  Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.
        
        public int LengthOfIncreasingLength(int[] nums) {
            if (nums == null || nums.Length == 0) return 0;

            int[] result = new int[nums.Length];
            for (int i = 0; i < result.Length; i++) {
                result[i] = 1;
            }
            for (int i = 1; i < nums.Length; i++) {
                for (int j = 0; j < i; j++) {
                    if (nums[i] > nums[j]) {
                        result[i] = Math.Max(result[i], result[j] + 1); // Update dp[i] with the maximum length of increasing subsequence ending at index i
                    }
                }
            }

            int maxlength = 0;
            foreach (int len in result) {
                maxlength = Math.Max(maxlength, len);
            }

            return maxlength;
        }
    }
}