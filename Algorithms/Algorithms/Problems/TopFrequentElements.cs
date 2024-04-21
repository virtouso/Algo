using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Problems
{
    public class TopFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k) {
            // Count the frequency of each element
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (int num in nums) {
                if (frequencyMap.ContainsKey(num)) {
                    frequencyMap[num]++;
                } else {
                    frequencyMap[num] = 1;
                }
            }

            // Sort the dictionary by value in descending order
            var sortedList = frequencyMap.OrderByDescending(pair => pair.Value);

            // Extract the top K frequent elements
            var topKFrequent = sortedList.Take(k).Select(pair => pair.Key).ToArray();

            return topKFrequent;
        }
    }
}