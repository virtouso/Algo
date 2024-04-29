using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class LargestSubarrayZeroSum
    {
        public  int[] FindLargestSubarrayWithZeroSum(int[] arr)
        {
            int maxLength = 0;
            int startIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == 0 && j - i + 1 > maxLength)
                    {
                        maxLength = j - i + 1;
                        startIndex = i;
                    }
                }
            }

            if (maxLength > 0)
            {
                int[] subarray = new int[maxLength];
                Array.Copy(arr, startIndex, subarray, 0, maxLength);
                return subarray;
            }
            else
            {
                return new int[0];
            }
        }
        
        public static int[] FindLargestSubarrayWithZeroSumPerformant(int[] arr)
        {
            Dictionary<int, int> sumIndexMap = new Dictionary<int, int>();
            int maxLength = 0;
            int startIndex = -1;

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (arr[i] == 0 && maxLength == 0)
                {
                    maxLength = 1;
                    startIndex = i;
                }

                if (sum == 0)
                {
                    maxLength = i + 1;
                    startIndex = 0;
                }

                if (sumIndexMap.ContainsKey(sum))
                {
                    int prevIndex = sumIndexMap[sum];
                    if (i - prevIndex > maxLength)
                    {
                        maxLength = i - prevIndex;
                        startIndex = prevIndex + 1;
                    }
                }
                else
                {
                    sumIndexMap[sum] = i;
                }
            }

            if (maxLength > 0)
            {
                int[] subarray = new int[maxLength];
                Array.Copy(arr, startIndex, subarray, 0, maxLength);
                return subarray;
            }
            else
            {
                return new int[0];
            }
        }
        
        
        
        
        
        
        
    }
}