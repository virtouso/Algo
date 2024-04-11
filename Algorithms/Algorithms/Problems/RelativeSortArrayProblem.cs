using System.Collections.Generic;

namespace Algorithms.Problems
{
    
    // Given two arrays arr1 and arr2, the elements of arr2 are distinct, and all elements in arr2 are also in arr1.
    //
    //     Sort the elements of arr1 such that the relative ordering of items in arr1 are the same as in arr2. Elements that do not appear in arr2 should be placed at the end of arr1 in ascending order.
    //
    //
    //
    //     Example 1:
    //
    // Input: arr1 = [2,3,1,3,2,4,6,7,9,2,19], arr2 = [2,1,4,3,9,6]
    // Output: [2,2,2,1,4,3,3,9,6,7,19]
    // Example 2:
    //
    // Input: arr1 = [28,6,22,8,44,17], arr2 = [22,28,8,6]
    // Output: [22,28,8,6,17,44]
    //
    //
    // Constraints:
    //
    // 1 <= arr1.length, arr2.length <= 1000
    // 0 <= arr1[i], arr2[i] <= 1000
    // All the elements of arr2 are distinct.
    //     Each arr2[i] is in arr1.
    //
    
    
    public class RelativeSortArrayProblem
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            // Create a dictionary to store the frequency of elements in arr1
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (int num in arr1) {
                if (!frequencyMap.ContainsKey(num))
                    frequencyMap[num] = 0;
                frequencyMap[num]++;
            }
        
            // Create a list to store the sorted result
            List<int> result = new List<int>();
        
            // Traverse arr2 and append the elements in the order specified in arr2
            foreach (int num in arr2) {
                int count = frequencyMap[num];
                for (int i = 0; i < count; i++) {
                    result.Add(num);
                }
                frequencyMap.Remove(num); // Remove the element from frequencyMap
            }
        
            // Append the remaining elements of arr1 in ascending order
            List<int> remaining = new List<int>(frequencyMap.Keys);
            remaining.Sort();
            foreach (int num in remaining) {
                int count = frequencyMap[num];
                for (int i = 0; i < count; i++) {
                    result.Add(num);
                }
            }
        
            return result.ToArray();
        }


        public void Run()
        {
          var result=   RelativeSortArray(new []{2,3,1,3,2,4,6,7,9,2,19}, new []{2,1,4,3,9,6});

        }
        
        
    }
}