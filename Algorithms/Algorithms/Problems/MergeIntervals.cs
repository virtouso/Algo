using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class MergeIntervals
    {
        public class Interval
        {
            public int start;
            public int end;

            public Interval(int s, int e)
            {
                start = s;
                end = e;
            }
        }


        public List<Interval> Merge(List<Interval> intervals)
        {
            if (intervals == null || intervals.Count == 0)
            {
                return new List<Interval>();
            }

            // Sort the intervals based on their start points
            intervals.Sort((a, b) => a.start.CompareTo(b.start));

            List<Interval> mergedIntervals = new List<Interval>();

            Interval prev = intervals[0];
            for (int i = 1; i < intervals.Count; i++)
            {
                Interval current = intervals[i];

                if (current.start <= prev.end)
                {
                    // Merge overlapping intervals
                    prev.end = Math.Max(prev.end, current.end);
                }
                else
                {
                    // Add non-overlapping interval to the result list
                    mergedIntervals.Add(prev);
                    prev = current;
                }
            }

            // Add the last interval to the result list
            mergedIntervals.Add(prev);

            return mergedIntervals;
        }
    }
}