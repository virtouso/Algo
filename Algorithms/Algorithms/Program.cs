using System;
using System.ComponentModel;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ClimbingStairs climb = new ClimbingStairs();
         var result=   climb.ClimbStairs(4);
         Console.WriteLine(result);
        }
    }
}