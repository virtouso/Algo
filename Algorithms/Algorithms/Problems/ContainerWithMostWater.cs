using System;

namespace Algorithms.Problems
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length-1;
            
            
            while (left<right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                int area = minHeight * width;

                maxArea = Math.Max(area, maxArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
                
            }

            return maxArea;
        }
    }
}