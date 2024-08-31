using System;

namespace Algorithms.Problems
{
    public class MeetingRooms
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
                return true;

            // Sort intervals by their start time
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            // Check for overlaps
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] < intervals[i - 1][1])
                {
                    return false; // Overlap found
                }
            }

            return true; // No overlaps
        }
    }
}