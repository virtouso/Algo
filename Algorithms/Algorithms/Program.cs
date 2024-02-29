using System;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            FindMinimumInRotatedSortedArray ar = new FindMinimumInRotatedSortedArray();
            Console.WriteLine(ar.FindMin(new []{3,4,5,1,2}));
            Console.WriteLine(ar.FindMin(new []{4,5,6,7,0,1,2}));
            Console.WriteLine(ar.FindMin(new []{11,13,15,17}));
        }
    }
}