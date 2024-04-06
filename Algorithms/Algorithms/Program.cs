using System;
using System.ComponentModel;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HouseRobber rob = new HouseRobber();
            rob.RobHouses(new[] { 1, 2, 3, 1 }, out var total);
        }
    }
}