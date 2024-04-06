using System;

namespace Algorithms.Problems
{
    public class LongestCommonSubsequenceProblem
    {
        // Example 1:
        //
        // Input: text1 = "abcde", text2 = "ace" 
        // Output: 3  
        // Explanation: The longest common subsequence is "ace" and its length is 3.
        // Example 2:
        //
        // Input: text1 = "abc", text2 = "abc"
        // Output: 3
        // Explanation: The longest common subsequence is "abc" and its length is 3.
        // Example 3:
        //
        // Input: text1 = "abc", text2 = "def"
        // Output: 0
        // Explanation: There is no such common subsequence, so the result is 0

        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];

            for (int i = 1; i <= text1.Length; i++) {
                for (int j = 1; j <= text2.Length; j++) {
                    if (text1[i - 1] == text2[j - 1]) {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    } else {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[text1.Length, text2.Length];
            
        }
    }
}