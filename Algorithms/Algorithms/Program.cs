using System;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var sum = new ThreeSome();
            Console.WriteLine(sum.ThreeSum(new []{-4,-2,-2,-2,0,1,2,2,2,3,3,4,4,6,6}));
        }
    }
}