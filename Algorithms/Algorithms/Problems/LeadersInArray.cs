using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class LeadersInArray
    {
        public  List<int> FindLeaders(int[] arr)
        {
            List<int> leaders = new List<int>();

            if (arr.Length == 0)
                return leaders;

            // Start from the rightmost element
            int maxFromRight = arr[arr.Length - 1];
            leaders.Add(maxFromRight);

            // Traverse the array from right to left
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > maxFromRight)
                {
                    // Found a new leader
                    maxFromRight = arr[i];
                    leaders.Add(maxFromRight);
                }
            }

            // Reverse the list to get leaders in their original order
            leaders.Reverse();
            return leaders;
    }
}