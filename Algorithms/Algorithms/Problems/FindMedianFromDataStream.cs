using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class FindMedianFromDataStream // hard
    {
        private List<int> low;  // Simulating max-heap (sorted in descending order)
        private List<int> high; // Simulating min-heap (sorted in ascending order)

        public FindMedianFromDataStream() {
            low = new List<int>();
            high = new List<int>();
        }

        public void addNum(int num) {
            // Add to low (simulating max-heap)
            if (low.Count == 0 || num <= low[low.Count - 1]) {
                low.Add(num);
                low.Sort((a, b) => b.CompareTo(a));  // Sort in descending order
            } else {
                // Add to high (simulating min-heap)
                high.Add(num);
                high.Sort();  // Sort in ascending order
            }

            // Balance the two halves
            if (low.Count > high.Count + 1) {
                // Move the largest element from low to high
                high.Add(low[low.Count - 1]);
                low.RemoveAt(low.Count - 1);
                high.Sort();
            } else if (high.Count > low.Count) {
                // Move the smallest element from high to low
                low.Add(high[0]);
                high.RemoveAt(0);
                low.Sort((a, b) => b.CompareTo(a));
            }
        }

        public double findMedian() {
            if (low.Count > high.Count) {
                return low[low.Count - 1];  // Median is the top of max-heap
            } else {
                return (low[low.Count - 1] + high[0]) / 2.0;  // Average of tops of both heaps
            }
        }
    }
}