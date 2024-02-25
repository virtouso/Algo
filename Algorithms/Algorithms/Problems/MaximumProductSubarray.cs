using System;
using System.Linq;

namespace Algorithms.Problems
{
    public class MaximumProductSubarray
    {
        public int MaxProduct(int[] nums) {
            var res = nums.ToList().Max();
            int curMin=1, curMax = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    curMax = curMin = 1;
                    continue;
                }

                var tmp = curMax * nums[i];
                curMax =  Math.Max( Math.Max(nums[i] * curMax, nums[i] * curMin),nums[i]);
                curMin =  Math.Min( Math.Min(tmp, nums[i] * curMin),nums[i]);
                res = Math.Max(res, curMax);
            }

            return res;
        }
    }
}