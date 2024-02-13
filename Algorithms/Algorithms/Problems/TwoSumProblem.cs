using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> refs = new Dictionary<int, int>();
            var result = new int[2];
            refs.Add(target - nums[0], 0);
            for (int i = 1; i < nums.Length; i++)
            {
                var goal = target - nums[i];
                if (refs.ContainsKey(target - goal))
                {
                    result[1] = i;
                    result[0] = refs[target - goal];
                    break;
                }

                else
                {
                    if (!refs.ContainsKey(goal))
                        refs.Add(goal, i);
                }
            }

            return result;
        }
    }
}