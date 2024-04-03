using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class DuplicateInList
    {
        public bool ContainsDuplicate(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }

            return result != 0;
        }

        public static int FindDuplicate(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                result ^= i;
            }

            return result;
        }


        public static int[] FindDuplicateWithIndex(int[] nums)
        {
            int duplicateValue = 0;
            int duplicateIndex = 0;

            Dictionary<int, int> seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!seen.ContainsKey(nums[i]))
                {
                    seen[nums[i]] = i;
                }
                else
                {
                    duplicateValue = nums[i];
                    duplicateIndex = seen[nums[i]];
                    break;
                }
            }

            return new int[] { duplicateValue, duplicateIndex };
        }
    }
}