using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class ThreeSum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
        
            // Sorting the array to use two pointers approach
            Array.Sort(nums);
        
            for (int i = 0; i < nums.Length - 2; i++) {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1])) {
                    int left = i + 1;
                    int right = nums.Length - 1;
                    int target = 0 - nums[i];
                
                    while (left < right) {
                        if (nums[left] + nums[right] == target) {
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        
                            // Skip duplicates
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;
                        
                            left++;
                            right--;
                        } else if (nums[left] + nums[right] < target) {
                            left++;
                        } else {
                            right--;
                        }
                    }
                }
            }
        
            return result;
        }

      
        
        
    }
}