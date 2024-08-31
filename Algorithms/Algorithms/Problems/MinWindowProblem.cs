using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class MinWindowProblem//hard
    {
         public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) {
            return "";
        }

        // Dictionary to store the frequency of characters in t
        var dictT = new Dictionary<char, int>();
        foreach (char c in t) {
            if (dictT.ContainsKey(c)) {
                dictT[c]++;
            } else {
                dictT[c] = 1;
            }
        }

        // Number of unique characters in t that must be present in the window
        int required = dictT.Count;

        // Left and Right pointers for sliding window
        int l = 0, r = 0;

        // Dictionary to keep track of all the characters in the current window
        var windowCounts = new Dictionary<char, int>();

        // Formed is used to keep track of how many unique characters in t
        // are present in the current window with the correct frequency
        int formed = 0;

        // (window length, left, right)
        int[] ans = {-1, 0, 0};

        while (r < s.Length) {
            char c = s[r];
            if (windowCounts.ContainsKey(c)) {
                windowCounts[c]++;
            } else {
                windowCounts[c] = 1;
            }

            // If the frequency of the current character added equals to the 
            // desired count in t then increment the formed count
            if (dictT.ContainsKey(c) && windowCounts[c] == dictT[c]) {
                formed++;
            }

            // Try and contract the window till the point where it ceases to be 'desirable'.
            while (l <= r && formed == required) {
                c = s[l];

                // Save the smallest window until now
                if (ans[0] == -1 || r - l + 1 < ans[0]) {
                    ans[0] = r - l + 1;
                    ans[1] = l;
                    ans[2] = r;
                }

                // The character at the position pointed by the `left` pointer is no longer a part of the window
                windowCounts[c]--;
                if (dictT.ContainsKey(c) && windowCounts[c] < dictT[c]) {
                    formed--;
                }

                // Move the left pointer ahead
                l++;
            }

            // Keep expanding the window by moving the right pointer
            r++;   
        }

        // Return the smallest window or empty string if no valid window was found
        return ans[0] == -1 ? "" : s.Substring(ans[1], ans[0]);
    }
    }
}