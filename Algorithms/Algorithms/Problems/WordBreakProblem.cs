using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class WordBreakProblem
    {
        // Example 1:
        //
        // Input: s = "leetcode", wordDict = ["leet","code"]
        // Output: true
        // Explanation: Return true because "leetcode" can be segmented as "leet code".
        // Example 2:
        //
        // Input: s = "applepenapple", wordDict = ["apple","pen"]
        // Output: true
        // Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
        // Note that you are allowed to reuse a dictionary word.
        //     Example 3:
        //
        // Input: s = "catsandog", wordDict = ["cats","dog","sand","and","cat"]
        // Output: false


        //method 1: DP
        // method 2: decision tree

        public bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> wordSet = new HashSet<string>(wordDict);
            int n = s.Length;
            bool[] dp = new bool[n + 1];
            dp[0] = true; // Empty string is always a valid word break

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && wordSet.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[n];
        }
    }
}