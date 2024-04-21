using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s) {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int maxSubstringLength = 0, left = 0, right = 0;

            while (right < n) {
                if (!set.Contains(s[right])) {
                    set.Add(s[right]);
                    maxSubstringLength = Math.Max(maxSubstringLength, right - left + 1);
                    right++;
                } else {
                    set.Remove(s[left]);
                    left++;
                }
            }

            return maxSubstringLength;
        }
    }
}