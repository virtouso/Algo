using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums) {
            if (nums == null || nums.Length == 0) {
                return 0;
            }

            HashSet<int> numSet = new HashSet<int>(nums);
            int longestStreak = 0;

            foreach (int num in numSet) {
                // Check if this number is the start of a sequence
                if (!numSet.Contains(num - 1)) {
                    int currentNum = num;
                    int currentStreak = 1;

                    // Count the length of the sequence
                    while (numSet.Contains(currentNum + 1)) {
                        currentNum += 1;
                        currentStreak += 1;
                    }

                    // Update the longest streak found
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }

        public void Run()
        {
            Console.WriteLine(LongestConsecutive( new []{100,4,200,1,2,3}));
        }
        
    }
}