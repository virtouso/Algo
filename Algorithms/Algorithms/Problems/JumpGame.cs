using System;

namespace Algorithms.Problems
{
    public class JumpGame
    {
        
        // You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.
        //
        //     Return true if you can reach the last index, or false otherwise.
        
        public bool CanJump(int[] nums)
        {
            int maxReach = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxReach)
                {
                    return false;
                }

                maxReach = Math.Max(maxReach, i + nums[i]);
                if (maxReach >= nums.Length - 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}