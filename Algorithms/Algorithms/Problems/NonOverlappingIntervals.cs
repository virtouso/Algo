using System.Linq;

namespace Algorithms.Problems
{
    public class NonOverlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals) {
            if (intervals.Length == 0) return 0;
        
            // Sort intervals by their end time
            intervals = intervals.OrderBy(interval => interval[1]).ToArray();
        
            int end = intervals[0][1];
            int count = 0;
        
            for (int i = 1; i < intervals.Length; i++) {
                if (intervals[i][0] < end) {
                    // Overlapping interval found
                    count++;
                } else {
                    // No overlap, update end time
                    end = intervals[i][1];
                }
            }
        
            return count;
        }
    }
}