using System;
using System.ComponentModel;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            ContainerWithMostWater solution = new  ContainerWithMostWater();
            int[] heights = {1, 8, 6, 2, 5, 4, 8, 3, 7};
            int maxArea = solution.MaxArea(heights);
            Console.WriteLine("Maximum Area of Water: " + maxArea);
        }
    }
}