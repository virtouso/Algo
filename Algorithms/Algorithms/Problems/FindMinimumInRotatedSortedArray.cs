namespace Algorithms.Problems
{
    public class FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            var result = nums[0];


            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1]) return nums[i];
            }

            return result;
        }
        
        public int FindMin2(int[] nums) {
            int left = 0;
            int right = nums.Length - 1;

      
            if (nums[left] <= nums[right]) {
                return nums[left];
            }

            while (left <= right) {
                int mid = left + (right - left) / 2;

            
                if (nums[mid] > nums[mid + 1]) {
                    return nums[mid + 1];
                }
              
                if (nums[mid - 1] > nums[mid]) {
                    return nums[mid];
                }

              
                if (nums[mid] > nums[0]) {
                    left = mid + 1;
                }
         
                else {
                    right = mid - 1;
                }
            }
            return -1; 
        }
        
        
    }
}