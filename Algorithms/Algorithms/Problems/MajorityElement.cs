using System;

namespace Algorithms.Problems
{
    public class MajorityElement
    {
        static int FindMajorityElement(int[] nums)
        {
            int candidate = 0;
            int count = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                    count = 1;
                }
                else if (num == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            // At this point, candidate is a potential majority element, but we need to verify it.
            count = 0;
            foreach (int num in nums)
            {
                if (num == candidate)
                {
                    count++;
                }
            }

            // If the count of candidate is greater than half the size of the array, then it's the majority element.
            if (count > nums.Length / 2)
            {
                return candidate;
            }
            else
            {
                // If there is no majority element, you might return -1 or throw an exception depending on your requirement.
                throw new Exception("No majority element found.");
            }
        }
    }
}