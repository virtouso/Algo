using System;
using System.Collections.Generic;
namespace Algorithms.Problems
{
    public class MeetingRooms2
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
            {
                return 0;
            }

            // Sort intervals by start time
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            // SortedSet to track the end times of meetings
            SortedSet<int> endTimes = new SortedSet<int>();

            // Add the end time of the first meeting
            endTimes.Add(intervals[0][1]);

            for (int i = 1; i < intervals.Length; i++)
            {
                // If the earliest end time is <= the start time of the current meeting
                if (endTimes.Min <= intervals[i][0])
                {
                    endTimes.Remove(endTimes.Min);
                }

                // Add the current meeting's end time
                endTimes.Add(intervals[i][1]);
            }

            // The size of the SortedSet is the number of rooms required
            return endTimes.Count;
        }
    }
}