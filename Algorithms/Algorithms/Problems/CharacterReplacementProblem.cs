using System;

namespace Algorithms.Problems
{
    public class CharacterReplacementProblem
    {
        public int CharacterReplacement(string s, int k) {
            int[] count = new int[26]; // Array to store the count of each character
            int maxCount = 0; // Maximum count of a single character in the current window
            int maxLength = 0; // Maximum length of the substring
            int left = 0; // Left pointer for the sliding window

            // Traverse the string with the right pointer
            for (int right = 0; right < s.Length; right++) {
                // Increment the count of the current character
                count[s[right] - 'A']++;
            
                // Update the maxCount with the maximum count of any single character in the current window
                maxCount = Math.Max(maxCount, count[s[right] - 'A']);
            
                // If the current window size minus the maxCount is greater than k, shrink the window
                if (right - left + 1 - maxCount > k) {
                    count[s[left] - 'A']--;
                    left++; // Move the left pointer to the right
                }
            
                // Calculate the maximum length of the window
                maxLength = Math.Max(maxLength, right - left + 1);
            }
        
            return maxLength;
        }
    }
}