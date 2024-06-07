using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();
            int i = 0;
            int n = intervals.Length;

            // Add all intervals before the new interval
            while (i < n && intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
                i++;
            }

            // Merge overlapping intervals with the new interval
            while (i < n && intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }

            result.Add(newInterval);

            // Add all intervals after the new interval
            while (i < n)
            {
                result.Add(intervals[i]);
                i++;
            }

            return result.ToArray();
        }
    }
}